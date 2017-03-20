using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace LeetcodeApp.common
{
    /// <summary>
    /// 加密解密操作类
    /// </summary>
    public class EncryptionHelper
    {
        /// <summary>
        /// Des加密  DES使用的密钥key为8字节，初始向量IV也是8字节。
        /// DES加密是以数据块为单位加密的，8个字节一个数据块，
        /// 如果待加密明byte[]的长度不是8字节的整数倍，算法先用值为“0”的byte补足8个字节，然后进行加密。
        /// 所以加密后的密文长度一定是8的整数倍。这样的密文解密后如果补了0值的byte，则解密后这些0值的byte依然存在
        /// </summary>
        /// <param name="plainTextArray"></param>
        /// <param name="Key"></param>
        /// <param name="IV"></param>
        /// <returns></returns>
        public static byte[] DesEncryptString(byte[] plainTextArray, byte[] Key, byte[] IV)
        {
            // 建立一个MemoryStream，这里面存放加密后的数据流
            MemoryStream mStream = new MemoryStream();

            // 使用MemoryStream 和key、IV新建一个CryptoStream 对象
            CryptoStream cStream = new CryptoStream(mStream,
                new TripleDESCryptoServiceProvider().CreateEncryptor(Key, IV),
                CryptoStreamMode.Write);

            // 将加密后的字节流写入到MemoryStream
            cStream.Write(plainTextArray, 0, plainTextArray.Length);

            //把缓冲区中的最后状态更新到MemoryStream，并清除cStream的缓存区
            cStream.FlushFinalBlock();

            // 把解密后的数据流转成字节流
            byte[] ret = mStream.ToArray();

            // 关闭两个streams.
            cStream.Close();
            mStream.Close();

            return ret;
        }

        /// <summary>
        /// Des解密
        /// </summary>
        /// <param name="EncryptedDataArray"></param>
        /// <param name="Key"></param>
        /// <param name="IV"></param>
        /// <returns></returns>
        public static byte[] DesDecryptTextFromMemory(byte[] EncryptedDataArray, byte[] Key, byte[] IV)
        {
            // 建立一个MemoryStream，这里面存放加密后的数据流
            MemoryStream msDecrypt = new MemoryStream(EncryptedDataArray);

            // 使用MemoryStream 和key、IV新建一个CryptoStream 对象
            CryptoStream csDecrypt = new CryptoStream(msDecrypt,
                new TripleDESCryptoServiceProvider().CreateDecryptor(Key, IV),
                CryptoStreamMode.Read);

            // 根据密文byte[]的长度（可能比加密前的明文长），新建一个存放解密后明文的byte[]
            byte[] DecryptDataArray = new byte[EncryptedDataArray.Length];

            // 把解密后的数据读入到DecryptDataArray
            csDecrypt.Read(DecryptDataArray, 0, DecryptDataArray.Length);

            msDecrypt.Close();
            csDecrypt.Close();

            return DecryptDataArray;
        }

        /// <summary>
        /// RSA加密
        /// RSA算法是一种非对称密码算法，所谓非对称，就是指该算法需要一对密钥，使用其中一个加密，则需要用另一个才能解密。
        /// RSA的算法涉及三个参数，n、e1、e2。
        /// 其中，n是两个大质数p、q的积，n的二进制表示时所占用的位数，就是所谓的密钥长度。
        /// e1和e2是一对相关的值，e1可以任意取，但要求e1与(p-1)*(q-1)互质;再选择e2，要求(e2* e1)mod((p-1)*(q-1))=1。
        /// (n及e1),(n及e2)就是密钥对。
        /// RSA加解密的算法完全相同,设A为明文，B为密文，则：A=B^e1 mod n；B=A^e2 mod n;
        /// e1和e2可以互换使用，即：
        /// A=B^e2 mod n；B=A^e1 mod n;
        /// </summary>
        /// <param name="publickey"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public static string RSAEncrypt(string publickey, string content)
        {
            publickey = @"<RSAKeyValue><Modulus>5m9m14XH3oqLJ8bNGw9e4rGpXpcktv9MSkHSVFVMjHbfv+SJ5v0ubqQxa5YjLN4vc49z7SVju8s0X4gZ6AzZTn06jzWOgyPRV54Q4I0DCYadWW4Ze3e+BOtwgVU1Og3qHKn8vygoj40J6U85Z/PTJu3hN1m75Zr195ju7g9v4Hk=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            byte[] cipherbytes;
            rsa.FromXmlString(publickey);
            cipherbytes = rsa.Encrypt(Encoding.UTF8.GetBytes(content), false);

            return Convert.ToBase64String(cipherbytes);
        }

        /// <summary>
        /// RSA解密
        /// </summary>
        /// <param name="privatekey"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public static string RSADecrypt(string privatekey, string content)
        {
            privatekey = @"<RSAKeyValue><Modulus>5m9m14XH3oqLJ8bNGw9e4rGpXpcktv9MSkHSVFVMjHbfv+SJ5v0ubqQxa5YjLN4vc49z7SVju8s0X4gZ6AzZTn06jzWOgyPRV54Q4I0DCYadWW4Ze3e+BOtwgVU1Og3qHKn8vygoj40J6U85Z/PTJu3hN1m75Zr195ju7g9v4Hk=</Modulus><Exponent>AQAB</Exponent><P>/hf2dnK7rNfl3lbqghWcpFdu778hUpIEBixCDL5WiBtpkZdpSw90aERmHJYaW2RGvGRi6zSftLh00KHsPcNUMw==</P><Q>6Cn/jOLrPapDTEp1Fkq+uz++1Do0eeX7HYqi9rY29CqShzCeI7LEYOoSwYuAJ3xA/DuCdQENPSoJ9KFbO4Wsow==</Q><DP>ga1rHIJro8e/yhxjrKYo/nqc5ICQGhrpMNlPkD9n3CjZVPOISkWF7FzUHEzDANeJfkZhcZa21z24aG3rKo5Qnw==</DP><DQ>MNGsCB8rYlMsRZ2ek2pyQwO7h/sZT8y5ilO9wu08Dwnot/7UMiOEQfDWstY3w5XQQHnvC9WFyCfP4h4QBissyw==</DQ><InverseQ>EG02S7SADhH1EVT9DD0Z62Y0uY7gIYvxX/uq+IzKSCwB8M2G7Qv9xgZQaQlLpCaeKbux3Y59hHM+KpamGL19Kg==</InverseQ><D>vmaYHEbPAgOJvaEXQl+t8DQKFT1fudEysTy31LTyXjGu6XiltXXHUuZaa2IPyHgBz0Nd7znwsW/S44iql0Fen1kzKioEL3svANui63O3o5xdDeExVM6zOf1wUUh/oldovPweChyoAdMtUzgvCbJk1sYDJf++Nr0FeNW1RB1XG30=</D></RSAKeyValue>";
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            byte[] cipherbytes;
            rsa.FromXmlString(privatekey);
            cipherbytes = rsa.Decrypt(Convert.FromBase64String(content), false);

            return Encoding.UTF8.GetString(cipherbytes);
        }

        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="EncryptString"></param>
        /// <returns>returns</returns>
        public static string MD5Encrypt(string EncryptString)
        {
            if (string.IsNullOrEmpty(EncryptString)) { throw (new Exception("密文不可为空")); }

            MD5 m_ClassMD5 = new MD5CryptoServiceProvider();
            string m_strEncrypt = "";

            try
            {
                m_strEncrypt = BitConverter.ToString(m_ClassMD5.ComputeHash(Encoding.Default.GetBytes(EncryptString))).Replace("-", "");
            }
            catch (ArgumentException ex) { throw ex; }
            catch (CryptographicException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
            finally { m_ClassMD5.Clear(); }

            return m_strEncrypt;

        }

        /// <summary>
        /// RC2 加密(用变长密钥对大量数据进行加密)
        /// </summary>
        /// <param name="EncryptString"></param>
        /// <param name="EncryptKey"></param>
        /// <returns>returns</returns>
        public static string RC2Encrypt(string EncryptString, string EncryptKey)
        {
            if (string.IsNullOrEmpty(EncryptString)) { throw (new Exception("密文不可为空")); }

            if (string.IsNullOrEmpty(EncryptKey)) { throw (new Exception("密钥不可为空")); }

            if (EncryptKey.Length < 5 || EncryptKey.Length > 16) { throw (new Exception("密钥必须为5-16位")); }

            string m_strEncrypt = "";
            byte[] m_btIV = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };
            RC2CryptoServiceProvider m_RC2Provider = new RC2CryptoServiceProvider();

            try
            {
                byte[] m_btEncryptString = Encoding.Default.GetBytes(EncryptString);
                MemoryStream m_stream = new MemoryStream();
                CryptoStream m_cstream = new CryptoStream(m_stream, m_RC2Provider.CreateEncryptor(Encoding.Default.GetBytes(EncryptKey), m_btIV), CryptoStreamMode.Write);
                m_cstream.Write(m_btEncryptString, 0, m_btEncryptString.Length);
                m_cstream.FlushFinalBlock();
                m_strEncrypt = Convert.ToBase64String(m_stream.ToArray());
                m_stream.Close();
                m_stream.Dispose();
                m_cstream.Close();
                m_cstream.Dispose();
            }
            catch (IOException ex) { throw ex; }
            catch (CryptographicException ex) { throw ex; }
            catch (ArgumentException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
            finally { m_RC2Provider.Clear(); }

            return m_strEncrypt;
        }

        /// <summary>
        /// RC2 解密
        /// </summary>
        /// <param name="DecryptString"></param>
        /// <param name="DecryptKey"></param>
        /// <returns>returns</returns>
        public static string RC2Decrypt(string DecryptString, string DecryptKey)
        {
            if (string.IsNullOrEmpty(DecryptString)) { throw (new Exception("密文不可为空")); }

            if (string.IsNullOrEmpty(DecryptKey)) { throw (new Exception("密钥不可为空")); }

            if (DecryptKey.Length < 5 || DecryptKey.Length > 16) { throw (new Exception("密钥必须为5-16位")); }

            byte[] m_btIV = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };
            string m_strDecrypt = "";
            RC2CryptoServiceProvider m_RC2Provider = new RC2CryptoServiceProvider();

            try
            {
                byte[] m_btDecryptString = Convert.FromBase64String(DecryptString);
                MemoryStream m_stream = new MemoryStream();
                CryptoStream m_cstream = new CryptoStream(m_stream, m_RC2Provider.CreateDecryptor(Encoding.Default.GetBytes(DecryptKey), m_btIV), CryptoStreamMode.Write);

                m_cstream.Write(m_btDecryptString, 0, m_btDecryptString.Length);
                m_cstream.FlushFinalBlock();
                m_strDecrypt = Encoding.Default.GetString(m_stream.ToArray());
                m_stream.Close();
                m_stream.Dispose();
                m_cstream.Close();
                m_cstream.Dispose();
            }
            catch (IOException ex) { throw ex; }
            catch (CryptographicException ex) { throw ex; }
            catch (ArgumentException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
            finally { m_RC2Provider.Clear(); }

            return m_strDecrypt;
        }

        /// <summary>
        /// AES 加密(高级加密标准，是下一代的加密算法标准，速度快，安全级别高，目前 AES 标准的一个实现是 Rijndael 算法)
        /// </summary>
        /// <param name="EncryptString"></param>
        /// <param name="EncryptKey"></param>
        /// <returns></returns>
        public static string AESEncrypt(string EncryptString, string EncryptKey)
        {
            if (string.IsNullOrEmpty(EncryptString)) { throw (new Exception("密文不得为空")); }

            if (string.IsNullOrEmpty(EncryptKey)) { throw (new Exception("密钥不得为空")); }

            string m_strEncrypt = "";
            byte[] m_btIV = Convert.FromBase64String("Rkb4jvUy/ye7Cd7k89QQgQ==");
            Rijndael m_AESProvider = Rijndael.Create();

            try
            {
                byte[] m_btEncryptString = Encoding.Default.GetBytes(EncryptString);
                MemoryStream m_stream = new MemoryStream();
                CryptoStream m_csstream = new CryptoStream(m_stream, m_AESProvider.CreateEncryptor(Encoding.Default.GetBytes(EncryptKey), m_btIV), CryptoStreamMode.Write);

                m_csstream.Write(m_btEncryptString, 0, m_btEncryptString.Length); m_csstream.FlushFinalBlock();
                m_strEncrypt = Convert.ToBase64String(m_stream.ToArray());
                m_stream.Close();
                m_stream.Dispose();
                m_csstream.Close();
                m_csstream.Dispose();
            }
            catch (IOException ex) { throw ex; }
            catch (CryptographicException ex) { throw ex; }
            catch (ArgumentException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
            finally { m_AESProvider.Clear(); }

            return m_strEncrypt;
        }

        /// <summary>
        /// AES 解密
        /// </summary>
        /// <param name="DecryptString"></param>
        /// <param name="DecryptKey"></param>
        /// <returns></returns>
        public static string AESDecrypt(string DecryptString, string DecryptKey)
        {
            if (string.IsNullOrEmpty(DecryptString)) { throw (new Exception("密文不得为空")); }

            if (string.IsNullOrEmpty(DecryptKey)) { throw (new Exception("密钥不得为空")); }

            string m_strDecrypt = "";
            byte[] m_btIV = Convert.FromBase64String("Rkb4jvUy/ye7Cd7k89QQgQ==");
            Rijndael m_AESProvider = Rijndael.Create();

            try
            {
                byte[] m_btDecryptString = Convert.FromBase64String(DecryptString);
                MemoryStream m_stream = new MemoryStream();
                CryptoStream m_csstream = new CryptoStream(m_stream, m_AESProvider.CreateDecryptor(Encoding.Default.GetBytes(DecryptKey), m_btIV), CryptoStreamMode.Write);

                m_csstream.Write(m_btDecryptString, 0, m_btDecryptString.Length); m_csstream.FlushFinalBlock();
                m_strDecrypt = Encoding.Default.GetString(m_stream.ToArray());
                m_stream.Close();
                m_stream.Dispose();
                m_csstream.Close();
                m_csstream.Dispose();
            }
            catch (IOException ex) { throw ex; }
            catch (CryptographicException ex) { throw ex; }
            catch (ArgumentException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
            finally { m_AESProvider.Clear(); }

            return m_strDecrypt;
        }
    }
}

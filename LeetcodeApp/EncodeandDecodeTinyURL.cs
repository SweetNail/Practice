using System.Collections.Generic;

namespace LeetcodeApp
{
    /// <summary>
    /// solution for Encode and Decode TinyURL 535
    /// </summary>
    public class EncodeandDecodeTinyURL
    {
        /*
            https://leetcode.com/problems/encode-and-decode-tinyurl/?tab=Solutions

            TinyURL is a URL shortening service where you enter a URL such as https://leetcode.com/problems/design-tinyurl and it returns a short URL such as http://tinyurl.com/4e9iAk.

            Design the encode and decode methods for the TinyURL service. There is no restriction on how your encode/decode algorithm should work. You just need to ensure that a URL can be encoded to a tiny URL and the tiny URL can be decoded to the original URL.
        */

        static Dictionary<int, string> map = new Dictionary<int, string>();
        static string prefix = "http://tinyurl.com/";

        // Encodes a URL to a shortened URL.
        public static string encode(string longUrl)
        {
            int hash = longUrl.GetHashCode();
            map.Add(hash, longUrl);

            return prefix + hash;
        }

        // Decodes a shortened URL to its original URL.
        public static string decode(string shortUrl)
        {
            return map[(int.Parse(shortUrl.Replace(prefix, "")))];
        }
    }
}

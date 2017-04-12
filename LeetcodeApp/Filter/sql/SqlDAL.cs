using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp.Filter.sql
{
    public abstract class SqlDAL : ContextBoundObject
    {
        private SqlTransaction _SqlTrans;

        /// <summary>
        /// 仅支持有事务时操作
        /// </summary>
        public SqlTransaction SqlTrans
        {
            get
            {
                if (_SqlTrans == null)
                {
                    //从上下文中试图取得事务
                    object obj = CallContext.GetData(TransactionAop.ContextName);

                    if (obj != null && obj is SqlTransaction)
                        _SqlTrans = obj as SqlTransaction;
                }

                return _SqlTrans;
            }

            set { _SqlTrans = value; }
        }
        
        #region ConnectionString

        private SqlConnectionStringBuilder _ConnectionString = null;

        /// <summary>
        /// 字符串连接
        /// </summary>
        public virtual SqlConnectionStringBuilder ConnectionString
        {
            get
            {
                if (_ConnectionString == null || string.IsNullOrEmpty(_ConnectionString.ConnectionString))
                {
                    _ConnectionString = new SqlConnectionStringBuilder(ConfigurationManager.AppSettings["MySetting"]);
                }

                return _ConnectionString;
            }

            set { _ConnectionString = value; }
        }
        
        #endregion
        
        #region ExecuteNonQuery
        
        public int ExecuteNonQuery(string cmdText)
        {
            if (SqlTrans == null)
                return SqlHelper.ExecuteNonQuery(ConnectionString.ConnectionString, CommandType.Text, cmdText);
            else
                return SqlHelper.ExecuteNonQuery(SqlTrans, CommandType.Text, cmdText);
        }
        
        public int ExecuteNonQuery(string cmdText, CommandType type)
        {
            if (SqlTrans == null)
                return SqlHelper.ExecuteNonQuery(ConnectionString.ConnectionString, type, cmdText);
            else
                return SqlHelper.ExecuteNonQuery(SqlTrans, type, cmdText);
        }
        
        public int ExecuteNonQuery(string cmdText, CommandType type, params SqlParameter[] cmdParameters)
        {
            if (SqlTrans == null)
                return SqlHelper.ExecuteNonQuery(ConnectionString.ConnectionString, type, cmdText, cmdParameters);
            else
                return SqlHelper.ExecuteNonQuery(SqlTrans, type, cmdText, cmdParameters);
        }

        #endregion
    }
}

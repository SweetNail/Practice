using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp.Filter.sql
{
    /// <summary>
    /// 标示方法内所有数据库操作加入事务控制
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public sealed class TransactionMethodAttribute : Attribute
    {
        /// <summary>
        /// 标示方法内所有数据库操作加入事务控制
        /// </summary>
        public TransactionMethodAttribute()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp.Filter.sql
{
    /// <summary>
    /// 标注类某方法内所有数据库操作加入事务控制
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public sealed class TransactionAttribute : ContextAttribute, IContributeObjectSink
    {

        /// <summary>
        /// 标注类某方法内所有数据库操作加入事务控制，请使用TransactionMethodAttribute同时标注
        /// </summary>
        public TransactionAttribute()
            : base("Transaction")
        { }

        public IMessageSink GetObjectSink(MarshalByRefObject obj, IMessageSink next)
        {
            return new TransactionAop(next);
        }
    }
}

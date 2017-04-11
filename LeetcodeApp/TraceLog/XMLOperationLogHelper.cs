using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp.TraceLog
{
    /// <summary>
    /// XML操作事务日志帮助类
    /// </summary>
    public class XMLOperationLogHelper<T> : IOperationLogHelper<T>
    {
        /// <summary>
        /// 获取操作事务日志列表
        /// </summary>
        /// <param name="sourceTable">源数据表</param>
        /// <returns></returns>
        public override IEnumerable<T> GetOperationLogList(string sourceTable)
        {
            return null;
        }

        /// <summary>
        /// 获取操作事务日志列表
        /// </summary>
        /// <param name="sourceTable">源数据表</param>
        /// <param name="userName">操作用户名</param>
        /// <returns></returns>
        public override IEnumerable<T> GetOperationLogList(string sourceTable, string userName)
        {
            return null;
        }

        /// <summary>
        /// 获取操作事务日志列表
        /// </summary>
        /// <param name="sourceTable">源数据表</param>
        /// <param name="userName">操作用户名</param>
        /// <param name="keyword">数据包含关键字</param>
        /// <returns></returns>
        public override IEnumerable<T> GetOperationLogList(string sourceTable, string userName, string keyword)
        {
            return null;
        }
    }
}

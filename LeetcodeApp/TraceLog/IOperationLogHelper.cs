using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp.TraceLog
{
    /// <summary>
    /// 操作事务日志帮助接口
    /// </summary>
    public abstract class IOperationLogHelper<T>
    {
        public static readonly string connectStr = System.Configuration.ConfigurationManager.AppSettings["connectStr"];

        /// <summary>
        /// 获取操作事务日志列表
        /// </summary>
        /// <param name="sourceTable">源数据表</param>
        /// <returns></returns>
        public abstract IEnumerable<T> GetOperationLogList(string sourceTable);

        /// <summary>
        /// 获取操作事务日志列表
        /// </summary>
        /// <param name="sourceTable">源数据表</param>
        /// <param name="userName">操作用户名</param>
        /// <returns></returns>
        public abstract IEnumerable<T> GetOperationLogList(string sourceTable, string userName);

        /// <summary>
        /// 获取操作事务日志列表
        /// </summary>
        /// <param name="sourceTable">源数据表</param>
        /// <param name="userName">操作用户名</param>
        /// <param name="keyword">数据包含关键字</param>
        /// <returns></returns>
        public abstract IEnumerable<T> GetOperationLogList(string sourceTable, string userName, string keyword);

        /// <summary>
        /// 记录操作日志
        /// </summary>
        /// <param name="log">操作</param>
        /// <param name="logData">操作数据</param>
        /// <returns></returns>
        public bool LogOperation(OperationLog log, OpearationLogData logData)
        {
            //todo : 记录操作日志到2张表中

            return false;
        }
    }
}

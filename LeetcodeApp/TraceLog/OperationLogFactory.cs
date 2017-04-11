using LeetcodeApp.TraceLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp.TraceLog
{
    /// <summary>
    /// 操作事务日志创建工厂
    /// </summary>
    public class OperationLogFactory<T>
    {
        /// <summary>
        /// 创建操作事务日志帮助类
        /// </summary>
        /// <param name="type">类型</param>
        /// <returns></returns>
        public IOperationLogHelper<T> Create(OperationLogType type)
        {
            switch(type)
            {
                case OperationLogType.XML: return new XMLOperationLogHelper<T>(); 
                case OperationLogType.JSON: return new JSONOperationLogHelper<T>();
                default:return null;
            }
        }
    }
}

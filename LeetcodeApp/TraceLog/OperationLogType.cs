using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp.TraceLog
{
    /// <summary>
    /// 操作实务日志类型
    /// </summary>
    public enum OperationLogType
    {
        XML = 1,
        JSON = 2
    }

    /// <summary>
    /// 操作类型
    /// </summary>
    public enum OperationType
    {
        CREATE = 1,
        RETRIEVE = 2,
        UPDATE = 3,
        DELETE = 4
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp.TraceLog
{
    /// <summary>
    /// 操作记录
    /// </summary>
    public class OperationLog
    {
        /// <summary>
        /// 操作事务日志
        /// </summary>
        public string TransactionID { get; set; }

        /// <summary>
        /// 操作人员Name
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime OperationTime { get; set; }

        /// <summary>
        /// 操作定义  自定义  方便查找
        /// </summary>
        public string OperationDefinition { get; set; }

        /// <summary>
        /// 操作描述
        /// </summary>
        public string OperationDescription { get; set; }
    }
}

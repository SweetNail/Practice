using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp.TraceLog
{
    /// <summary>
    /// 操作事务数据记录类
    /// </summary>
    public class OpearationLogData
    {
        /// <summary>
        /// 事务数据记录ID   主键
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// 操作事务ID  外键  OperationLog => TransctionID
        /// </summary>
        public string TransactionID { get; set; }

        /// <summary>
        /// 数据源表
        /// </summary>
        public string SourceTable { get; set; }

        /// <summary>
        /// 数据变更记录  XML表示
        /// </summary>
        public string DataChange { get; set; }
    }
}

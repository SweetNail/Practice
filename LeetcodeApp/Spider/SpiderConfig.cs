using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp.Spider
{
    /// <summary>
    /// 配置项
    /// </summary>
    public class SpiderConfig
    {
        /// <summary>
        /// 处理线程数
        /// </summary>
        public int ThreadNum { get; set; }

        /// <summary>
        /// 处理深度
        /// </summary>
        public int Deep { get; set; }

        /// <summary>
        /// 超时时间  秒
        /// </summary>
        public int TimeOut { get; set; }

        /// <summary>
        /// 是否重试
        /// </summary>
        public bool Retry { get; set; }

        /// <summary>
        /// 重试间隔  秒
        /// </summary>
        public bool RetryInterval { get; set; }

        /// <summary>
        /// 爬取地址
        /// </summary>
        public string URL { get; set; }
    }
}

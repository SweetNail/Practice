using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp.Spider
{
    /// <summary>
    /// 主线程
    /// </summary>
    public class Spider
    {
        #region Properties

        private SpiderConfig _config = new SpiderConfig();

        #endregion

        #region 构造函数

        public Spider() { }

        public Spider(SpiderConfig config)
        {
            this._config = config;
        }

        #endregion

        /// <summary>
        /// 启动
        /// </summary>
        public void Start()
        {
            Console.WriteLine("Spider process start...");



            Console.WriteLine("Spider process end...");
        }
    }
}

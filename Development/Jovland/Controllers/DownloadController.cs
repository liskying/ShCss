using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Jovland.Controllers
{
    public class DownloadController : Controller
    {
        //
        // GET: /Download/

        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 公司业绩报表
        /// </summary>
        /// <returns></returns>
        public ActionResult ComPerfomance()
        {
            return View();
        }

        /// <summary>
        /// 文件下载列表
        /// </summary>
        /// <param name="categoryType"></param>
        /// <returns></returns>
        public ActionResult Downloadlist(string categoryType)
        {
            return View();
        }

        

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Infomation.Controllers
{
    public class InitController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Init()
        {
            return View();
        }

        /// <summary>
        /// 进入桌面
        /// </summary>
        /// <returns></returns>
        public IActionResult CMSDesk()
        {
            return View();
        }
    }
}
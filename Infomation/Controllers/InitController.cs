using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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

        [HttpPost]
        public ActionResult Login(IFormCollection form)
        {
            //获取参数
            string userName = form["userName"];
            string passWord = form["password"];
            string validateCode = form["validateCode"];

            //调用服务
            

            string msg="";

            return Content(msg);
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
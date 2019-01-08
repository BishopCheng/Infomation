using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
            //加载页面时生成验证码，生成后添加入缓存，然后显示到页面上
            string webapiurl = "http://localhost:51385/LoginService/login";
             
            var httpResponse = new HttpResponseMessage();
            using (var httpClient  = new HttpClient())
            {
                 

            }
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
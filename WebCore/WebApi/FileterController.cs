﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebCore.Fileters;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebCore.WebApi
{
    [AddHeaderResultFilter]
    [ActionFilter]
    [MyExceptionFilter]
    [MyFormatFilter]
    [MyAuthorizationFilter]
    //[MyServiceFilter(typeof(FileterController))]//添加后无法访问了？？？
    [MyTypeFilter(typeof(FileterController))]
    [Route("api/Fileter")]
    [ApiController]
    public class FileterController : Controller
    {
        [ShortCircuitingResourceFilter]
        [HttpGet(nameof(ShortCircuitingResource))]
        public string ShortCircuitingResource()
        {
            return "如果成功被拦截，消息不返回，而是拦截过滤器返回的信息";
        }

        [HttpGet(nameof(GetFileterExcutedMsg))]
        public IActionResult GetFileterExcutedMsg()
        {
            //throw new Exception("测试异常");
            return Content("经过各种过滤器之后的返回信息，观察http网络请求");
        }
    }
}

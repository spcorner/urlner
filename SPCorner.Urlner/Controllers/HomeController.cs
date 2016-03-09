using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace SPCorner.Urlner.Controllers
{
    [Route("", Name = "Home", Order = 1)]
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Get()
        {
            var time = DateTime.UtcNow.ToString("hh:mm:ss");

            return Content($"<h2>[{time}] Welcome to Urlner!</h2>");
        }
    }
}

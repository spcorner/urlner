using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPCorner.Urlner.Controllers
{
    [Route("", Name = "link", Order=0)]
    public class LinkController : Controller
    {
        [HttpGet("{slug}")]
        public IActionResult Get(string slug)
        {
            var time = DateTime.UtcNow.ToString("hh:mm:ss");

            return Content($"<h1>[{time}] Redirecting to: {slug}</h1>");
        }
    }
}

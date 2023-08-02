using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace programs.Controllers
{
    // [Route("[controller]")]
    public class ejercicio2 : Controller
    {
        String[] data = { "Eren jaeger", "Mikasa Ackerman", "Armin Arlert", "Levi Ackerman", "Erwin Smith" };
        private readonly ILogger<ejercicio2> _logger;

        public ejercicio2(ILogger<ejercicio2> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }

        public IActionResult SearchByPos(int pos)
        {
            pos--;
            try
            {
                ViewBag.str = data[pos];
                ViewBag.Pos = pos;
            }
            catch (System.Exception ex)
            {
                ViewBag.str = ex.Message;
            }
            return View();
        }

        public IActionResult SearchByString(string str)
        {
            try
            {
                foreach (String dataStr in data)
                {
                    if (str.Equals(dataStr, StringComparison.OrdinalIgnoreCase))
                    {
                        ViewBag.strFound = str;
                        return View();
                    }
                }
                ViewBag.strFound = "The string was not found";
            }
            catch (System.Exception)
            {

                throw;
            }
            return View();
        }
    }
}
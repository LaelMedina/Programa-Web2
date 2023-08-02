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
    public class ejercicio1 : Controller
    {
        private readonly ILogger<ejercicio1> _logger;

        public ejercicio1(ILogger<ejercicio1> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public String convert(String str = "default text")
        {
            char[] char_str = str.ToUpper().ToCharArray(); //convert the input string to an uppercased array
            Array.Reverse(char_str); //reverse the characters of the array not the string, the array.
            return new string(char_str);//return a new string which is already reversed
        }

        public String compare(String str1, String str2)
        {
            if (str1.Equals(str2, StringComparison.OrdinalIgnoreCase))
            {
                return str1 + " and " + str2 + " do are equals";
            }
            else
            {
                return str1 + " and " + str2 + " are not equals";

            }
        }

        public IActionResult profile(String name, int age, String career)
        {
            ViewBag.Name = name;
            ViewBag.Age = age;
            ViewBag.Career = career;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}
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
    public class Test : Controller
    {
        private readonly ILogger<Test> _logger;

        public Test(ILogger<Test> logger)
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

        public IActionResult getAverage(float grade1, float grade2, float grade3)
        {
            float result = (grade1 + grade2 + grade3) / 3;

            ViewBag.grade1 = grade1;
            ViewBag.grade2 = grade2;
            ViewBag.grade3 = grade3;


            ViewBag.result = result;
            return View();
        }

        public IActionResult isPalindromo(string word)
        {
            // Elimina los espacios en blanco y convierte a minúsculas
            word = word.Replace(" ", "").ToLower();

            char[] arrayWord = word.ToCharArray();
            Array.Reverse(arrayWord); //aloh
            string invertedWord = new String(arrayWord);

            // Compara la palabra original con la invertida
            if (word == invertedWord)
            {
                ViewBag.result = "The word -" + word + "- is a palindromo";
            }
            else
            {
                ViewBag.result = "The word: -" + word + "- is NOT a palindromo";

            }
            return View();
        }

        public IActionResult getFactorial(int number)
        {
            long factorial = 1;
            ViewBag.number = number;

            if (number < 0 || number == 0)
            {
                throw new ArgumentException("El número debe ser positivo o cero.");//how can I read this sentence in other page
            }

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            ViewBag.factorial = factorial;

            return View();
        }
    }
}
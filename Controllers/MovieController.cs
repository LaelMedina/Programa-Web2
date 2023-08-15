using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using programs.Models;
using Newtonsoft.Json;

namespace programs.Controllers;
public class MovieController : Controller
{
    public List<Movie> lstMovies = null;
    public MovieController()
    {
        var myJsonString = System.IO.File.ReadAllText("Models/Movie.json");
        lstMovies = JsonConvert.DeserializeObject<List<Movie>>(myJsonString);
    }

    public IActionResult Index()
    {
        return View(lstMovies);
    }
}

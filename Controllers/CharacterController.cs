using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using programs.Models;
using Newtonsoft.Json;

namespace programs.Controllers;
public class CharacterController : Controller
{
    public List<Character> lstCharacters = null;
    public CharacterController()
    {
        var myJsonString = System.IO.File.ReadAllText("Models/Characters.json");
        lstCharacters = JsonConvert.DeserializeObject<List<Character>>(myJsonString);
    }

    public IActionResult Index()
    {
        return View(lstCharacters);
    }

    public IActionResult Find(string character)
    {
        List<Character> lstResultCharacter = new List<Character>();

        try
        {
            foreach (var item in lstCharacters)
            {
                if (item.Name.ToLower().Contains(character.ToLower()))
                {
                    lstResultCharacter.Add(item);
                }
            }
            return View("Index", lstResultCharacter);
        }
        catch (NullReferenceException ex)
        {
            return View("Index", lstCharacters);
        }
    }

    public IActionResult Details(int id)
    {
        foreach (var item in lstCharacters)
        {
            if (item.Id == id)
            {
                return View(item);
            }
        }

        return View(new Character());
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{
    public class HomeController : Controller
    {
        // [HttpGet("")]
        public IActionResult Names(){
            string[] names=new string[]{
                "vicky","Benny Bob", "John Wick","Kahn","Dominic Toredo"
            };
            return View(names);
        }
        [HttpGet("")]
        public IActionResult Index()
        {
             string message = "Message friom Action REsult";
            // ViewBag.Message = message;
            return View("Index",message);
        }
        [HttpGet("numbers")]
        public IActionResult Numbers(){
            int[] number = new int[]{
                1,2,343,3,2,234,234,2423,423,4234,234,234,234,234,234,23,4234
            };
            return View(number);
        }
        [HttpGet("users")]
        public IActionResult Users(){
            List<User> Users = new List<User>(){
                new User(){FirstName = "Vicky", LastName="Hell"},
                new User(){FirstName = "Vicky", LastName="Hell"},
                new User(){FirstName = "Vicky", LastName="Hell"},
                new User(){FirstName = "Vicky", LastName="Hell"},
                new User(){FirstName = "Vicky", LastName="Hell"},
            };
            return View(Users);
        }
        [HttpGet("user")]
        public IActionResult SingleUser(){

            return View(new User(){FirstName = "Vicky", LastName="Hell"});
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

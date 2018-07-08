using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BSAAsp.NetCorePractice.Models;

namespace BSAAsp.NetCorePractice.Controllers
{
    public class HomeController : Controller
    {
        DataGiver Data;

        public HomeController(DataGiver data)
        {
            Data = data;
        }

        public IActionResult Index()
        {
            return View(Data.Users);
        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

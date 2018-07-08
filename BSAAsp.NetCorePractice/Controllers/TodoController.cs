using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BSAAsp.NetCorePractice.Controllers
{
    public class TodoController : Controller
    {
        DataGiver Data;

        public TodoController(DataGiver data)
        {
            Data = data;
        }

        // GET: Todo/Details/5
        public ActionResult Details(int id)
        {
            return View(Data.GetTodoes().FirstOrDefault(t => t.Id == id));
        }

    }
}
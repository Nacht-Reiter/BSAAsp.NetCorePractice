using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BSAAsp.NetCorePractice.Controllers
{
    public class UserController : Controller
    {
        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BSAAsp.NetCorePractice.Controllers
{
    public class TodoController : Controller
    {
        // GET: Todo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

    }
}
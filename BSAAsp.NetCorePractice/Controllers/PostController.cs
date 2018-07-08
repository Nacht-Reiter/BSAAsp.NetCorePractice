﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BSAAsp.NetCorePractice.Controllers
{
    public class PostController : Controller
    {
        DataGiver Data;

        public PostController(DataGiver data)
        {
            Data = data;
        }

        // GET: Post/Details/5
        public ActionResult Details(int id)
        {
            return View(Data.GetPosts().FirstOrDefault(p => p.Id == id));
        }
    }
}
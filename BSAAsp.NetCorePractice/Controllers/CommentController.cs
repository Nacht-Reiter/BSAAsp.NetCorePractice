using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BSAAsp.NetCorePractice.Controllers
{
    public class CommentController : Controller
    {
        DataGiver Data;

        public CommentController(DataGiver data)
        {
            Data = data;
        }

        // GET: Comment/Details/5
        public ActionResult Details(int id)
        {
            return View(Data.GetComments().FirstOrDefault(c => c.Id == id));
        }

    }
}
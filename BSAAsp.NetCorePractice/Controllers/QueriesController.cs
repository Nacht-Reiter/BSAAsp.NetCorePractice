using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BSAAsp.NetCorePractice.Controllers
{
    public class QueriesController : Controller
    {
        private Queries queries;

        public QueriesController(Queries queries)
        {
            this.queries = queries;
        }



        // GET: Queries/CountCommentsUnderPosts
        [HttpGet]
        public ActionResult CountCommentsUnderPosts()
        {
            return View();
        }

        // GET: Queries/CountCommentsUnderPosts/5
        [HttpGet]
        public ActionResult CountCommentsUnderPostsShow(int id)
        {
            return View(queries.CountCommentsUnderPosts(id));
        }

        // POST: Queries/CountCommentsUnderPosts
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CountCommentsUnderPosts(int id)
        {
            try
            {
                return RedirectToAction($"CountCommentsUnderPostsShow/{id}");
            }
            catch
            {
                return View();
            }
        }

    }
}
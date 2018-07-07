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
        public ActionResult CountCommentsUnderPosts(User user)
        {
            if (user.Id > queries.GetMaxUserId())
            {
                ModelState.AddModelError("Id", "User is not exist");
            }
            if (ModelState.IsValid)
            {
                return RedirectToAction($"CountCommentsUnderPostsShow/{user.Id}");
            }
            return View();
        }


        // GET: Queries/GetShortCommentsUnderPosts
        [HttpGet]
        public ActionResult GetShortCommentsUnderPosts()
        {
            return View();
        }

        // GET: Queries/GetShortCommentsUnderPostsShow/5
        [HttpGet]
        public ActionResult GetShortCommentsUnderPostsShow(int id)
        {
            return View(queries.GetShortCommentsUnderPosts(id));
        }

        // POST: Queries/GetShortCommentsUnderPosts
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult GetShortCommentsUnderPosts(User user)
        {
            if (user.Id > queries.GetMaxUserId())
            {
                ModelState.AddModelError("Id", "User is not exist");
            }
            if (ModelState.IsValid)
            {
                return RedirectToAction($"GetShortCommentsUnderPostsShow/{user.Id}");
            }
            return View();
        }

        // GET: Queries/GetCompleteTodoes
        [HttpGet]
        public ActionResult GetCompleteTodoes()
        {
            return View();
        }

        // GET: Queries/GetCompleteTodoesShow/5
        [HttpGet]
        public ActionResult GetCompleteTodoesShow(int id)
        {
            return View(queries.GetCompleteTodoes(id));
        }

        // POST: Queries/GetCompleteTodoes
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult GetCompleteTodoes(User user)
        {
            if (user.Id > queries.GetMaxUserId())
            {
                ModelState.AddModelError("Id", "User is not exist");
            }
            if (ModelState.IsValid)
            {
                return RedirectToAction($"GetCompleteTodoesShow/{user.Id}");
            }
            return View();
        }

        // GET: Queries/GetSortedUsers
        [HttpGet]
        public ActionResult GetSortedUsers()
        {
            return View(queries.GetSortedUsers());
        }


        // GET: Queries/GetUserInfo
        [HttpGet]
        public ActionResult GetUserInfo()
        {
            return View();
        }

        // GET: Queries/GetUserInfoShow/5
        [HttpGet]
        public ActionResult GetUserInfoShow(int id)
        {
            return View(queries.GetUserInfo(id));
        }

        // POST: Queries/GetUserInfo
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult GetUserInfo(User user)
        {
            if (user.Id > queries.GetMaxUserId())
            {
                ModelState.AddModelError("Id", "User is not exist");
            }
            if (ModelState.IsValid)
            {
                return RedirectToAction($"GetUserInfoShow//{user.Id}");
            }
            return View();
        }

        // GET: Queries/GetPostInfo
        [HttpGet]
        public ActionResult GetPostInfo()
        {
            return View();
        }

        // GET: Queries/GetPostInfoShow/5
        [HttpGet]
        public ActionResult GetPostInfoShow(int id)
        {
            return View(queries.GetPostInfo(id));
        }

        // POST: Queries/GetPostInfo
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult GetPostInfo(Post post)
        {
            if (post.Id > queries.GetMaxPostId())
            {
                ModelState.AddModelError("Id", "Post is not exist");
            }
            if (ModelState.IsValid)
            {
                return RedirectToAction($"GetPostInfoShow/{post.Id}");
            }
            return View();
        }
    }
}
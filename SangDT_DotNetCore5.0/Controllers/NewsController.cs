using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace SangDT_DotNetCore5._0.Controllers
{
    public class NewsController : Controller
    {
        /*
        // GET: NewsController1
        public ActionResult Index()
        {
            return View();
        }

        // GET: NewsController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NewsController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NewsController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NewsController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NewsController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NewsController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NewsController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        */

        public string StringOut()
        {
            return ("Hello Sang");
        }
        public string StringId(int id)
        {
            return ($"Hello Ngan có ID: {id}");
        }
        public string StringMany(int id, string firstname, string lastname)
        {
            return ($"Hello A N có ID: {id} - My Name is {firstname} {lastname}");
        }
        public string StringEmployee(int id, Employee employee)
        {
            return ($"Hello A N có ID: {id} - My Name is {employee.FirstName} {employee.LastName}");
        }
        public IActionResult StringActionResult(int id, Employee employee)
        {
            return Content($"Hello A N có ID: {id} - My Name is {employee.FirstName} {employee.LastName}");
        }
        public IActionResult StringJson(int id, Employee employee)
        {
            var result = new {Id = id, Employee = employee};
            return Json(result);   
        }
        public ActionResult Index()
        {
            var article = new List<Article>
            {
                new Article { Id = 1,  Title = "Title 01", Content = "This is content 01", Author = "DTS"},
                new Article { Id = 2,  Title = "Title 02", Content = "This is content 02", Author = "DTS"},
                new Article { Id = 3,  Title = "Title 03", Content = "This is content 03", Author = "DTS"},
                new Article { Id = 4,  Title = "Title 04", Content = "This is content 04", Author = "DTS"},
                new Article { Id = 7,  Title = "Title 05", Content = "This is content 05", Author = "DTS"},
                new Article { Id = 6,  Title = "Title 06", Content = "This is content 06", Author = "DTS"},
                new Article { Id = 7,  Title = "Title 07", Content = "This is content 07", Author = "DTS"},
                new Article { Id = 8,  Title = "Title 08", Content = "This is content 08", Author = "DTS"}
            };

            //option 1: using ViewBag
            //ViewBag.Article = article;
            //option 2: using ViewData
            ViewData["Article"] = article;
            //option 3: using DataModel
            return View(article); //dùng cho option 3

            //return View(); dùng cho option 1 ,2
        }
    }

    public class Employee
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }

    public class Article
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }
    }
}

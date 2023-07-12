using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
    }

    public class Employee
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}

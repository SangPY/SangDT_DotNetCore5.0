using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SangDT_DotNetCore5._0.Controllers
{
    public class AdminController : Controller
    {
        
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
        
    }
}

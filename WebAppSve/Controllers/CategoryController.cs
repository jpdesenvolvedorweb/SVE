using Business;
using Entities.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace WebAppSve.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            return View(Category.List());
        }

        // GET: Category/Details/5
        public ActionResult Details(int id)
        {
            return View(new Category().List(id));
        }

        // GET: Category/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Category/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category category)
        {
            
            category.Save();
            MessageError();
            return View("Create");
        }

        // GET: Category/Edit/5
        public ActionResult Edit(int id)
        {
            return View(new Category().List(id));
        }

        // POST: Category/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Category category)
        {
            category.Save();
            MessageError();
            return View();
        }

        // GET: Category/Delete/5
        public ActionResult Delete(int id)
        {
            return View(new Category().List(id));
        }

        // POST: Category/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Category category)
        {
            category.Delete();
            MessageError();
            return RedirectToAction("Index");
        }

        private void MessageError()
        {
            ViewBag.MessageError = Message.Show();
        }
    }
}
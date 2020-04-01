using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Todos.Models;

namespace Todos.Controllers
{
    public class TodosController : Controller
    {
        private TodosContext db = new TodosContext();

        // GET: Todos
        public ActionResult Index()
        {
            return View(db.Todos.OrderByDescending(t => t.Id)
                                .Take(5)
                                .ToList());
        }

        // GET: Todos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Todo todo = db.Todos.Find(id);
            if (todo == null)
            {
                return HttpNotFound();
            }
            return View(todo);
        }

        // GET: Todos/Add
        public ActionResult Add()
        {
            return View();
        }

        // POST: Todos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Todo todo)
        {
            if (ModelState.IsValid)
            {
                todo.AddedOn = DateTime.Now;
                db.Todos.Add(todo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(todo);
        }

        // GET: Todos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Todo todo = db.Todos.Find(id);
            if (todo == null)
            {
                return HttpNotFound();
            }
            return View(todo);
        }

        // POST: Todos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Todo todo)
        {
            if (ModelState.IsValid)
            {
                var dbTodo = db.Todos.Find(id);
                dbTodo.Category = todo.Category;
                dbTodo.Text = todo.Text;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(todo);
        }

        // GET: Todos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Todo todo = db.Todos.Find(id);
            if (todo == null)
            {
                return HttpNotFound();
            }

            db.Todos.Remove(todo);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Search()
        {
            return View();
        }

        public ActionResult DoSearch(string searchtext)
        {
            var todos = db.Todos.Where(t => t.Text.Contains(searchtext))
                                .OrderByDescending(t => t.Id);

            return PartialView("SearchResults", todos.ToList<Todo>());
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

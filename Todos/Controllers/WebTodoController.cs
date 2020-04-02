using System;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using Todos.Models;

namespace Todos.Controllers
{
    public class WebTodoController : ApiController
    {
        private TodosContext db = new TodosContext();

        // GET: api/WebTodo
        [HttpGet]
        public IQueryable<Todo> GetTodos()
        {
            return db.Todos.OrderByDescending( t => t.Id);
        }

        // GET: api/WebTodo/5
        [ResponseType(typeof(Todo))]
        public IHttpActionResult GetTodo(int id)
        {
            Todo todo = db.Todos.Find(id);
            if (todo == null)
            {
                return NotFound();  // 404
            }

            return Ok(todo);
        }

        // PUT: api/WebTodo/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTodo(int id, Todo todo)
        {
            var dbTodo = db.Todos.Find(id);
            if (dbTodo == null)
            {
                return NotFound();  // 404
            }

            dbTodo.Category = todo.Category;
            dbTodo.Text = todo.Text;

            try
            {
                db.SaveChanges();
            }
            catch (Exception)
            {
                return StatusCode(HttpStatusCode.InternalServerError); // 500
            }

            return StatusCode(HttpStatusCode.NoContent);  // 204
        }

        // POST: api/WebTodo
        [ResponseType(typeof(Todo))]
        public IHttpActionResult PostTodo(Todo todo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);  // 400
            }

            todo.AddedOn = DateTime.Now;
            db.Todos.Add(todo);
            db.SaveChanges();
            return Ok(todo); // 200
        }

        // DELETE: api/WebTodo/5
        [ResponseType(typeof(Todo))]
        public IHttpActionResult DeleteTodo(int id)
        {
            Todo todo = db.Todos.Find(id);
            if (todo == null)
            {
                return NotFound();
            }

            db.Todos.Remove(todo);
            db.SaveChanges();

            return Ok(todo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TodoExists(int id)
        {
            return db.Todos.Count(e => e.Id == id) > 0;
        }
    }
}
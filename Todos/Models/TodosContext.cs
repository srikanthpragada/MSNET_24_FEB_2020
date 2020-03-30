using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todos.Models 
{
    public class TodosContext : DbContext 
    {
        public TodosContext()
            : base(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=msdb;Integrated Security=True")
        {
            //Disable initializer
            Database.SetInitializer<TodosContext>(null);
        }

        public DbSet<Todo> Todos { get; set; }
    }
}

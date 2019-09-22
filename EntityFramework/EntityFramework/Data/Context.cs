using EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Data
{
    public class Context: DbContext
    {
        public DbSet<Person> People { get; set; }
           
    }
}

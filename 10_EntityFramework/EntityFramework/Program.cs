using EntityFramework.Data;
using EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<Context>());
            using (var context = new Context())
            {
                //context.People.Add(new Person()
                //{
                //    Name = "James Churchill",
                //    BirthDate = new DateTime(1968, 4, 22),
                //    Weight = 215


               
                //});

               
                context.Database.Log = (message) => Console.WriteLine(message);
                var people = context.People.Where(p => p.IsStarWarsFan).ToList();

                context.SaveChanges();
                foreach (var person in people)
                {
                    Console.WriteLine(person.Info);
                }

                
                //do something with this
            }

                


            Console.ReadKey();
        }
    }
}

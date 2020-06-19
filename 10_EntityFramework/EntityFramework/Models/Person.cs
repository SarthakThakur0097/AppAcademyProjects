using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    [Table("FunnyPeople")]
    public class Person
    {
        public int Id { get; set;}
        [Column("FullName")]
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsStarWarsFan { get; set; }

        public decimal Weight { get; set; }

        //This property doesn't have a setter
        //So Ef will ignore it when generating the database;
        public string Info
        {
            get
            {
                return $"{Name} ({BirthDate})";

            }
        }
    }
}

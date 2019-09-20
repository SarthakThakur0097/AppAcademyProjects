using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace InvoiceMaker.Models
{
    public class WorkType
    {
        public WorkType()
        {

        }
        public WorkType(int id, string name, decimal rate)
        {
            this.Id = id;
            this.Name = name;
            this.Rate = rate;   
        }

        [Required, Column("WorkTypeName"), MaxLength(255)]
        public string Name
        {
            get; private set;
        }

        [Required, Column("Rate")]
        public decimal Rate
        {
            get; private set;
        }

        public int Id { get; set; }


    }
}
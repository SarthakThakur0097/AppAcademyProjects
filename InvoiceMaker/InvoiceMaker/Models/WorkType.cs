using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InvoiceMaker.Models
{
    public class WorkType
    {
        public WorkType(string name, double rate)
        {
            this.Name = name;
            this.Rate = rate;   
        }

        public string Name
        {
            get; private set;
        }

        public double Rate
        {
            get; private set;
        }


    }
}
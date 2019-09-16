using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InvoiceMaker.Models
{
    public class FeeLineItem:ILineItem
    {
        string description;
        double amount;
        DateTimeOffset occurence;
        
        public FeeLineItem(string description, double amount, DateTimeOffset occurence)
        {
            this.description = description;
            this.amount = amount;
            this.occurence = occurence;
        }
        

        public double Amount
        {
            get
            {
                return this.amount;
            }
           
        }

        public string Description
        {
            get
            {
                return this.description;
            }
        }

        public DateTimeOffset When
        {
            get
            {
                return this.occurence;
            }
        }
    }
}
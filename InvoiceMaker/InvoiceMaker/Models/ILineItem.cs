using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InvoiceMaker.Models
{
    public interface ILineItem
    {
        double Amount
        {
            get;
        }

        string Description
        {
            get;
        }

        DateTimeOffset When
        {
            get;
        }


    }
}
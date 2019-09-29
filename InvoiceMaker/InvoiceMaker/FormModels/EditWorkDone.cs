using InvoiceMaker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InvoiceMaker.FormModels
{
    public class EditWorkDone
    {
        public Client Client { get; set; }
        public WorkType WorkType { get; set; }

    }
}
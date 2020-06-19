using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InvoiceMaker.Models
{
    public class WorkLineItem:ILineItem
    {
        WorkDone _workDone;

        public WorkLineItem(WorkDone workDone)
        {
            _workDone = workDone;
        }

        public decimal Amount
        {
            get
            {
                return _workDone.GetTotal();
            }
        }

        public string Description
        {
            get
            {
                return _workDone.WorkTypeName;
            }
        }

        public DateTimeOffset When
        {
            get
            {
                return _workDone.StartedOn.DateTime;
            }
        }
    }
}
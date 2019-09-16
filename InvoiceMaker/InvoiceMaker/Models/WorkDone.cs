using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InvoiceMaker.Models
{
    public class WorkDone
    {

        private Client _client;
        private WorkType _workType;
        

        public DateTimeOffset StartedOn
        {
            get;
            private set;
        }

        
        public DateTimeOffset? EndedOn
        {
            get; private set;
        }
        public string ClientName
        {
            get
            {
                return _client.Name;
            }
        }

        public string WorkTypeName
        {
            get
            {
                return _workType.Name;
            }
        }
        
        public WorkDone(Client client, WorkType workType)
        {
            StartedOn = DateTimeOffset.Now;
  
            _client = client;
            _workType = workType;
        }

        public WorkDone(Client client, WorkType workType, DateTimeOffset startedOn)
            :this(client, workType)
        {
            StartedOn = startedOn;           
        }

        public WorkDone(Client client, WorkType workType, DateTimeOffset startedOn, DateTimeOffset endedOn)
            :this(client, workType, startedOn)
        {
            EndedOn = endedOn;
        }

        public void Finished()
        {
            EndedOn = DateTimeOffset.Now;
        }

        public double GetTotal()
        {
            if(EndedOn!= null)
            {
                double hoursWorked = (StartedOn - EndedOn.Value).TotalHours ;

                return _workType.Rate * hoursWorked;
            }
            return 0;
        }

    }
}
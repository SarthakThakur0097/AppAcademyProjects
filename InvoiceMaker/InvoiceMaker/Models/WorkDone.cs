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
        
        public int Id
        {
            get; private set;
        }
        public WorkDone(int id, Client client, WorkType workType)
        {
            this.Id = id;
            StartedOn = DateTimeOffset.Now;
  
            _client = client;
            _workType = workType;
        }

        public WorkDone(int id, Client client, WorkType workType, DateTimeOffset startedOn)
            :this(id, client, workType)
        {
            StartedOn = startedOn;           
        }

        public WorkDone(int id, Client client, WorkType workType, DateTimeOffset startedOn, DateTimeOffset endedOn)
            :this(id, client, workType, startedOn)
        {
            EndedOn = endedOn;
        }

        public void Finished()
        {
            EndedOn = DateTimeOffset.Now;
        }

        public decimal GetTotal()
        {
            if(EndedOn!= null)
            {
                decimal hoursWorked = (decimal)(StartedOn - EndedOn.Value).TotalHours ;

                return _workType.Rate * hoursWorked;
            }
            return 0;
        }

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace InvoiceMaker.Models
{
    public class WorkDone
    {

        //private Client _client;
        //private WorkType _workType;

         public Client Client
        {
            get;set;
        }
        public WorkType WorkType
        {
            get;set;
        }
        
        public WorkDone()
        {

        }
        
        public int ClientId
        {
            get
            {
                return Client.Id;

            }
        }

        [Column("WorkTypeRate")]
        public decimal WorkTypeRate
        {
            get
            {
                return WorkType.Rate;
            }
        }
        [Required, Column("WorkTypeId")]
        public int WorkTypeId
        {
            get
            {
                return WorkType.Id;

            }
        }
        [Column("StartedOn")]
        public DateTimeOffset StartedOn
        {
            get;
            private set;
        }

        [Column("EndedOn")]
        public DateTimeOffset? EndedOn
        {
            get; private set;
        }
        [Column("ClientName")]
        public string ClientName
        {
            get
            {
                return Client.Name;
            }
        }
        [Column("WorkTypeName")]
        public string WorkTypeName
        {
            get
            {
                return WorkType.Name;
            }
        }
        
        public int Id
        {
            get; set;
        }
        public WorkDone(int id, Client client, WorkType workType)
        {
            this.Id = id;
            StartedOn = DateTimeOffset.Now;
  
            Client = client;
            WorkType = workType;
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
                decimal hoursWorked = (decimal)(EndedOn.Value - StartedOn).TotalHours;

                return WorkType.Rate * hoursWorked;
            }
            return 0;
        }

    }
}
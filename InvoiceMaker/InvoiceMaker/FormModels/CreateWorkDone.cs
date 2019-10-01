using InvoiceMaker.Models;
using InvoiceMaker.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InvoiceMaker.Data;

namespace InvoiceMaker.FormModels
{
    public class CreateWorkDone
    {
        public int ClientId { get; set; }
        public int WorkTypeId { get; set; }
        public DateTimeOffset StartedOn { get; set; }


        public IList<Client> Clients { get; set; }
        public IList<WorkType> WorkTypes { get; set; }
        public SelectList ClientSelectList
        {
            get
            {
                return new SelectList(Clients, "Id", "Name");
            }
        }
        public SelectList WorkTypeSelectList
        {
            get
            {
                return new SelectList(WorkTypes, "Id", "Name");
            }
        }
        public void PopulateSelectLists(Context context)
        {
            ClientRepo cRepo = new ClientRepo(context);
            WorkTypeRepo wtRepo = new WorkTypeRepo(context);

            Clients = cRepo.GetClients();
            WorkTypes = wtRepo.GetWorkTypes();
        }

    }
}
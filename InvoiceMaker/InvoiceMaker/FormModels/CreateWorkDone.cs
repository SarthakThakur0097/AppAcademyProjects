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

        private Context _context = new Context();


        public int ClientId { get; set; }
        public int WorkTypeId { get; set; }
        public DateTimeOffset StartedOn { get; set; }


        public IList<Client> Clients { get; set; }
        public IList<WorkType> WorkTypes { get; set; }
        public List<WorkDone> WorkDones { get; set; }
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
        public void PopulateSelectLists()
        {
            ClientRepository cRepo = new ClientRepository(_context);
            WorkTypeRepo wtRepo = new WorkTypeRepo(_context);

            Clients = cRepo.GetClients();
            WorkTypes = wtRepo.GetWorkTypes();
        }

    }
}
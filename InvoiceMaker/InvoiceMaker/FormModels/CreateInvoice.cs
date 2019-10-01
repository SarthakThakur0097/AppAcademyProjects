using InvoiceMaker.Data;
using InvoiceMaker.Models;
using InvoiceMaker.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InvoiceMaker.FormModels
{
    public class CreateInvoice
    {
        public IList<Client> Clients { get; set; }
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string InvoiceNumber { get; set; }
        public InvoiceStatus Status { get; set; }

        
        public SelectList ClientSelectList
        {
            get
            {
                return new SelectList(Clients, "Id", "Name");
            }
        }

        public void PopulateSelectLists(Context _context)
        {
            ClientRepository cRepo = new ClientRepository(_context);
            Clients = cRepo.GetClients();

        }
    }
}
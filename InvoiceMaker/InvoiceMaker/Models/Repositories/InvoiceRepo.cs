using InvoiceMaker.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace InvoiceMaker.Models.Repositories
{
    public class InvoiceRepo
    {
        private Context _context;

        public InvoiceRepo(Context context)
        {
            _context = context;
        }

        public IList<Invoice> GetInvoices()
        {
            return _context.Invoices.
                 Include(i => i.Client)
                .ToList();
        }

        public Invoice GetById(int id)
        {
            return _context.Invoices.SingleOrDefault(c => c.Id == id);
        }

        public void Insert(Invoice invoice)
        {
            _context.Invoices.Add(invoice);
            _context.SaveChanges();
        }
    }
}
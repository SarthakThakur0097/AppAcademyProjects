using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace InvoiceMaker.Models
{
    public class Invoice
    {
        public int Id { get; set; }

        public InvoiceStatus Status { get; set; }

        public string InvoiceNumber { get; set; }

        public DateTimeOffset StartedOn
        {
            get;
            set;
        }

        public int ClientId { get; set; }
        public Client Client { get; set; }
        public List<ILineItem> LineItems { get; set; }

        public Invoice()
        {

        }
        public Invoice(string invoiceNumber)
        {
            InvoiceNumber = invoiceNumber;
            LineItems = new List<ILineItem>();
            Status = InvoiceStatus.Open;
        }

        public Invoice(string invoiceNumber, InvoiceStatus status)
            : this(invoiceNumber)
        {
            Status = status;
        }

        public Invoice(string invoiceNumber, InvoiceStatus status, int clientId)
            : this(invoiceNumber)
        {
            Status = status;
            ClientId = clientId;
        }

        public void FinalizeInvoice()
        {
            if (Status == InvoiceStatus.Open)
            {
                Status = InvoiceStatus.Finalized;
            }
        }

        public void CloseInvoice()
        {
            if (Status == InvoiceStatus.Finalized)
            {
                Status = InvoiceStatus.Closed;
            }
        }

        public void AddWorkLineItem(WorkDone workDone)
        {
            LineItems.Add(new WorkLineItem(workDone));
        }

        public void AddFeeLineItem(string description, decimal amount, DateTimeOffset when)
        {
            LineItems.Add(new FeeLineItem(description, amount, when));
        }
       
    }
}
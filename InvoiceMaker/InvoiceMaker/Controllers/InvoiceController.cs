using InvoiceMaker.Data;
using InvoiceMaker.FormModels;
using InvoiceMaker.Models;
using InvoiceMaker.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InvoiceMaker.Controllers
{
    public class InvoiceController : Controller
    {
        private Context context = new Context();
        // GET: Invoivce
        
        [HttpGet]
        public ActionResult Index()
        {
            var repository = new InvoiceRepo(context);
            IList<Invoice> invoices = repository.GetAllInvoices();

            return View("Index", invoices);
        }


        [HttpGet]
        public ActionResult Create()
        {
            var formModel = new CreateInvoice();
            formModel.PopulateSelectLists();
            return View("Create", formModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateInvoice formModel)
        {
            InvoiceRepo repo = new InvoiceRepo(context);

            try
            {
                var invoice = new Invoice(formModel.InvoiceNumber, formModel.Status, formModel.ClientId);
                invoice.Status = InvoiceStatus.Open;
                repo.Insert(invoice);
                return RedirectToAction("Index");
            }
            catch (DbUpdateException ex)
            {
                HandleDbUpdateException(ex);
            }

            formModel.PopulateSelectLists();
            return View("Create", formModel);
        }

        private void HandleDbUpdateException(DbUpdateException ex)
        {
            throw new NotImplementedException();
        }

        //[HttpGet]
        //public ActionResult Edit()
        //{
        //    CreateInvoice model = new CreateInvoice();
        //    model.PopulateSelectLists();

        //    return View("Create", model);
        //}
    }
}
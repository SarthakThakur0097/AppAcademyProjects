using InvoiceMaker.Data;
using InvoiceMaker.FormModels;
using InvoiceMaker.Models;
using InvoiceMaker.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InvoiceMaker.Controllers
{
    public class WorkDoneController : Controller
    {
        // GET: WorkDone
        private Context context;

        public WorkDoneController()
        {
            context = new Context();
        }
        [HttpGet]
        public ActionResult Create()
        {
            CreateWorkDone model = new CreateWorkDone();
            model.PopulateSelectLists();
            //model.Clients = new ClientRepository(null).GetClients();
            model.WorkTypes = new WorkTypeRepo(context).GetWorkTypes();

            return View("Create", model);
        }

        [HttpPost]
        public ActionResult Create(CreateWorkDone model)
        {
            try
            {
                // Get the client and work type based on values submitted from
                // the form
                Client client = new ClientRepository(context).GetById(model.ClientId);
                WorkType workType = new WorkTypeRepo(context).GetById(model.WorkTypeId);

                // Create an instance of the work done with the client and work
                // type
                WorkDone workDone = new WorkDone(0, client, workType);

                var wRepo = new WorkDoneRepo(context);
                wRepo.Insert(workDone);
                return RedirectToAction("Index");
            }
            catch { }

            // Create a view model
            CreateWorkDone viewModel = new CreateWorkDone();
            model.PopulateSelectLists();

            // Copy over the values from the values submitted
            viewModel.ClientId = model.ClientId;
            viewModel.StartedOn = model.StartedOn;
            viewModel.WorkTypeId = model.WorkTypeId;
            viewModel.WorkDones = new WorkDoneRepo(context).GetWorkDones();

            // Go get the value for the drop-downs, again.
            //viewModel.Clients = new ClientRepository(context).GetClients();
            viewModel.WorkTypes = new WorkTypeRepo(context).GetWorkTypes();
            return View("Create", viewModel);
        }

        [HttpGet]
        public ActionResult Index()
        {
            WorkDoneRepo repo = new WorkDoneRepo(context);
            IList<WorkDone> workDones = repo.GetWorkDones();
            return View("Index", workDones);
        }

    }
}
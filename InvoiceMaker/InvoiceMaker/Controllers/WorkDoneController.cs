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
            //model.WorkTypes = new WorkTypeRepo(context).GetWorkTypes();

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

          
            viewModel.ClientId = model.ClientId;
            viewModel.StartedOn = model.StartedOn;
            viewModel.WorkTypeId = model.WorkTypeId;
            

         
            //viewModel.WorkTypes = new WorkTypeRepo(context).GetWorkTypes();
            return View("Create", viewModel);
        }

        [HttpGet]
        public ActionResult Index()
        {
            WorkDoneRepo repo = new WorkDoneRepo(context);
            IList<WorkDone> workDones = repo.GetWorkDones();
            return View("Index", workDones);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var cRepository = new ClientRepository(context);
            Client client = cRepository.GetById(id);
           // var wtRepository = new WorkTypeRepo(context);

            var formModel = new EditWorkDone();
            //formModel.Client = 
                

            return View("Edit", formModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, EditWorkDone formModel)
        {
            var cRepository = new ClientRepository(context);
            var wRepository = new WorkTypeRepo(context);
            var wdRepository = new WorkDoneRepo(context);
            try
            {
                Client cToEdit = cRepository.GetById(formModel.Client.Id);
                WorkType wToEdit = wRepository.GetById(formModel.WorkType.Id);
                var workDone = new WorkDone(id, cToEdit, wToEdit);
                wdRepository.Update(workDone);
                return RedirectToAction("Index");
            }
            catch (DbUpdateException ex)
            {
                HandleDbUpdateException(ex);
            }

            return View("Edit", formModel);
        }

        private void HandleDbUpdateException(DbUpdateException ex)
        {
            throw new NotImplementedException();
        }
    }
}
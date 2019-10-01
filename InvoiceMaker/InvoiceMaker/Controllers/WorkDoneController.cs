using InvoiceMaker.Data;
using InvoiceMaker.FormModels;
using InvoiceMaker.Models;
using InvoiceMaker.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
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
            model.PopulateSelectLists(context);

            return View("Create", model);
        }

        [HttpPost]
        public ActionResult Create(CreateWorkDone model)
        {
            try
            {
              
                Client client = new ClientRepo(context).GetById(model.ClientId);
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
            viewModel.PopulateSelectLists(context);

            viewModel.ClientId = model.ClientId;
            viewModel.StartedOn = model.StartedOn;
            viewModel.WorkTypeId = model.WorkTypeId;
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
            var wdRepository = new WorkDoneRepo(context);
            WorkDone workDone = wdRepository.GetById(id);
           
            var model = new EditWorkDone();
            model.Client = workDone.Client;
            model.WorkType = workDone.WorkType;
            model.PopulateSelectLists(context);
            return View("Edit", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, EditWorkDone formModel)
        {
            var cRepository = new ClientRepo(context);
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
            if (ex.InnerException != null && ex.InnerException.InnerException != null)
            {
                SqlException sqlException =
                    ex.InnerException.InnerException as SqlException;
                if (sqlException != null && sqlException.Number == 2627)
                {
                    ModelState.AddModelError("Name", "That name is already taken.");
                }
            }
        }
    }
}
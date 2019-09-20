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
    public class WorkTypeController : Controller
    {

        private Context context;
        
        public WorkTypeController()
        {
            context = new Data.Context();
        }
        // GET: WorkType
        [HttpGet]
        public ActionResult Index()
        {
            var repo = new WorkTypeRepo(context);
            //List<WorkType> workTypes = repo.GetWorkTypes();
            IList<WorkType> workTypes = repo.GetWorkTypes();
            return View("Index", workTypes);
        }

        [HttpGet]
        public ActionResult Create()
        {
            var workType = new CreateWorkType();
       
            return View("Create", workType);
        }

        [HttpPost]
        public ActionResult Create(CreateWorkType formModel)
        {
            var repo = new WorkTypeRepo(context);
            try
            {
                var newWorkType = new WorkType(0,formModel.Name, formModel.Rate);
                repo.Insert(newWorkType);
                return RedirectToAction("Index");
            }
            catch (DbUpdateException ex)
            {
                //HandleDbUpdateException(ex);
            }
            return View("Create", formModel);
        }

    

        [HttpGet]
        public ActionResult Edit(int id)
        {
            WorkTypeRepo repo = new WorkTypeRepo(context);
            WorkType workType = repo.GetById(id);

            EditWorkType model = new EditWorkType();
            //model.Id = client.Id;
            model.Id = id;
            model.Name = workType.Name;
            model.Rate = workType.Rate;
            return View("Edit", model);
        }

        [HttpPost]
        public ActionResult Edit(int id, EditWorkType workType)
        {
            WorkTypeRepo repo = new WorkTypeRepo(context);
            try
            {
                WorkType newWorkType = new WorkType(id, workType.Name, workType.Rate);
                repo.Update(newWorkType);
                return RedirectToAction("Index");
            }
            catch (SqlException se)
            {
                if (se.Number == 2627)
                {
                    ModelState.AddModelError("Name", "That name is already taken.");
                }
            }
            return View("Edit", workType);
        }
    }
}
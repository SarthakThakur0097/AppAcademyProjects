using InvoiceMaker.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace InvoiceMaker.Models.Repositories
{
    public class WorkTypeRepo
    {
        private Context _context;
        public WorkTypeRepo(Context context)
        {
            _context = context;
        }
        public List<WorkType> GetWorkTypes()
        {
            return _context.WorkTypes.ToList();
        }


        public WorkType GetById(int id)
        {
            return _context.WorkTypes.SingleOrDefault(c => c.Id == id);
        }

        //private string _connectionString = ConfigurationManager.ConnectionStrings["InvoiceMakerMvc"].ConnectionString;

        public void Insert(WorkType workType)
        {
            _context.WorkTypes.Add(workType);
            _context.SaveChanges();
        }




        public void Update(WorkType workType)
        {
            _context.WorkTypes.Attach(workType);
            _context.Entry(workType).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
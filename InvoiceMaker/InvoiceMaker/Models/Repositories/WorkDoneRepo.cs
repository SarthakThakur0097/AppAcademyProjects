using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using InvoiceMaker.Data;
using System.Data.Entity;

namespace InvoiceMaker.Models.Repositories
{
    public class WorkDoneRepo
    {
        
        private readonly Context _context;

        public WorkDoneRepo(Context context )
        {
            _context = context;
        }

        public List<WorkDone> GetWorkDones()
        {
            return _context.WorkDones
                .Include(wd => wd.Client)
                .Include(wd => wd.WorkType)
                .ToList();
        }
        public void Update(WorkDone workDone)
        {
            _context.WorkDones.Attach(workDone);
            _context.Entry(workDone).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Insert(WorkDone workDone)
        {
            _context.WorkDones.Add(workDone);
            _context.SaveChanges();
        }


        public WorkDone GetById(int id)
        {
            return _context.WorkDones.SingleOrDefault(c => c.Id == id);
        }
    }
}
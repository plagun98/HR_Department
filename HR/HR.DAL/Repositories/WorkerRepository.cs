using System;
using System.Collections.Generic;
using System.Linq;
using HR.DAL.Entities;
using HR.DAL.EF;
using HR.DAL.Interfaces;
using System.Data.Entity;

namespace HR.DAL.Repositories
{
    public class WorkerRepository : IRepository<Worker>
    {
        private WorkerContext db;

        public WorkerRepository(WorkerContext context)
        {
            this.db = context;
        }

        public IEnumerable<Worker> GetAll()
        {
            return db.Workers;
        }

        public Worker Get(int id)
        {
            return db.Workers.Find(id);
        }

        public void Create(Worker worker)
        {
            db.Workers.Add(worker);
        }

        public void Update(Worker worker)
        {
            db.Entry(worker).State = EntityState.Modified;
        }

        public IEnumerable<Worker> Find(Func<Worker, Boolean> predicate)
        {
            return db.Workers.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            Worker book = db.Workers.Find(id);
            if (book != null)
                db.Workers.Remove(book);
        }
    }
}
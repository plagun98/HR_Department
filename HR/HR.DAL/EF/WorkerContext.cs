using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using HR.DAL.Entities;

namespace DAL.EF
{
    public class WorkerContext : DbContext
    {
        public DbSet<Worker> Workers { get; set; }

        static WorkerContext()
        {
            Database.SetInitializer<WorkerContext>(new WorkerDbInitializer());
        }
        public WorkerContext(string connectionString)
            : base(connectionString)
        {
        }
    }

    public class WorkerDbInitializer : DropCreateDatabaseAlways<WorkerContext>
    {
        protected override void Seed(WorkerContext db)
        {
            db.Workers.Add(new Worker { Name = "Lionel", Surname = "Messi", SalaryNumber = 10, Subdivision = "Начальство", Position = "Goal Manager", Experience = 13 });
            db.Workers.Add(new Worker { Name = "Cristina", Surname = "Ronaldo", SalaryNumber = 7, Subdivision = "Рядовые рабочие", Position = "Уборщик", Experience = 15 });
            db.Workers.Add(new Worker { Name = "Sergio", Surname = "Ramos", SalaryNumber = 4, Subdivision = "Рядовые рабочие", Position = "Уборщик", Experience = 15 });

            base.Seed(db);
        }
    }
}
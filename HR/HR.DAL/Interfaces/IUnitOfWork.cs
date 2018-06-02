using HR.DAL.Entities;
using System;

namespace HR.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Worker> Workers { get; }
        void Save();
    }
}
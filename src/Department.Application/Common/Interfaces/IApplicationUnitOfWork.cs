using Department.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.Application.Common.Interfaces
{
    public interface IApplicationUnitOfWork:IAsyncDisposable , IDisposable
    {
        Task<bool> SaveChangaseAsync();
        public DbSet<Employee> Employees { get; }
        public DbSet<Departments> Departments { get; }

    }
}

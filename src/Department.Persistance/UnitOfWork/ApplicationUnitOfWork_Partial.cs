using Department.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.Persistance.UnitOfWork
{
    public partial class ApplicationUnitOfWork
    {
        public DbSet<Employee> Employees => _context.Set<Employee>();
        public DbSet<Departments> Departments => _context.Set<Departments>();

    }
}

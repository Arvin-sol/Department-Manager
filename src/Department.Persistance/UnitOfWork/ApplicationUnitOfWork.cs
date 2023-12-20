using Department.Application.Common.Interfaces;
using Department_managment.Persistance.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.Persistance.UnitOfWork
{
    public partial class ApplicationUnitOfWork : IApplicationUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public ApplicationUnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }


        public void Dispose()
        {
            _context.Dispose();
        }

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public async Task<bool> SaveChangaseAsync()
        {
            
            return await _context.SaveChangesAsync() > 0 ;
        }
    }
}

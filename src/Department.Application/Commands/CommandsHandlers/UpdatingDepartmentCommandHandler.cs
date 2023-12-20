using Department.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.Application.Commands.CommandsHandlers
{
    public class UpdatingDepartmentCommandHandler : IRequestHandler<UpdatingDepartmentCommand, bool>
    {
        private readonly IApplicationUnitOfWork _uow;
        public UpdatingDepartmentCommandHandler(IApplicationUnitOfWork unitOfWork)
        {
            _uow = unitOfWork;
        }
        public async Task<bool> Handle(UpdatingDepartmentCommand request, CancellationToken cancellationToken)
        {
            var x = await _uow.Departments.FirstOrDefaultAsync(x => x.ID == request.ID);
            if (x != null)
            {
                x.FlagSRC = request.FlagSRC;
                x.Budget = request.Budget;
            }
            return await _uow.SaveChangaseAsync();
        }
    }
}

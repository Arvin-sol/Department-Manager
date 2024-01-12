using Department.Application.Common.Interfaces;
using Department.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.Application.Commands.CommandsHandlers
{
    public class CreateDepartmentCommandHandler : IRequestHandler<CreateDepartmentCommand, bool>
    {
        private readonly IApplicationUnitOfWork _uow;
        public CreateDepartmentCommandHandler(IApplicationUnitOfWork uow)
        {
            _uow = uow;
        }
        public async Task<bool> Handle(CreateDepartmentCommand request, CancellationToken cancellationToken)
        {
            var newDepartment = new Departments
            {
                Budget = request.DepartmentDTO.budget,
                DepartmentName = request.DepartmentDTO.Name,
                Location = request.DepartmentDTO.Location,
                FlagSRC = "src"
            };
            await _uow.Departments.AddAsync(newDepartment);
            return await _uow.SaveChangaseAsync();
        }
    }
}

using Department.Application.Common.Interfaces;
using Department.Application.DTOs;
using Department.Domain.Entities;
using MediatR;

namespace Department.Application.Commands.CommandsHandlers
{
    public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand, bool>
    {
        private readonly IApplicationUnitOfWork _uow;
        public CreateEmployeeCommandHandler(IApplicationUnitOfWork uow)
        {
            _uow = uow;
        }
        public async Task<bool> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var newEmployee = new Employee
            {
                Name = request.Employee.Name,
                BirthDay = request.Employee.BirthDay,
                Salary = request.Employee.Salary,
                DepartmentID = request.Employee.Department
            };

            await _uow.Employees.AddAsync(newEmployee);
            return await _uow.SaveChangaseAsync();
            
        }
    }
}

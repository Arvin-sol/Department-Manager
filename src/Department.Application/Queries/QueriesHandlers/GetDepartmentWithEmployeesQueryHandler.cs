using Department.Application.Common.Interfaces;
using Department.Application.DTOs;
using MediatR;
using Department.Application.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Department.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Department.Application.Queries.QueriesHandlers
{
    public class GetDepartmentWithEmployeesQueryHandler :
        IRequestHandler<GetDepartmentWithEmployeesQuery, DepartmentWithEmployeeListDTO>
    {
        private readonly IApplicationUnitOfWork _uow;
        public GetDepartmentWithEmployeesQueryHandler(IApplicationUnitOfWork unitOfWork)
        {
            _uow = unitOfWork;
        }
        public async Task<DepartmentWithEmployeeListDTO> Handle(GetDepartmentWithEmployeesQuery request, CancellationToken cancellationToken)
        {
            var DepartmentList = await _uow.Departments.Where(x => x.Employees.Count() >= request.x).ToListAsync();
            var DepartmentNamesList =  DepartmentList.Select(x=>x.DepartmentName).ToList();
            var DepartmentID = DepartmentList.Select(x=>x.ID).ToList();

            var EmployeeDTOList = await _uow.Employees
                .AsQueryable()
                .Where(x => DepartmentID.Contains(x.ID))
                .Select(x => x.ConvertToEmployeeDTO()).ToListAsync();


            return new DepartmentWithEmployeeListDTO
            {
                DepartmentName = DepartmentNamesList,
                Employees = EmployeeDTOList
            };
        }
    }
}

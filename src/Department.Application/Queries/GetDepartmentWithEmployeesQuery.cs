using Department.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.Application.Queries
{
    public class GetDepartmentWithEmployeesQuery:IRequest<DepartmentWithEmployeeListDTO>
    {
        public int x { get; set; }
    }
}

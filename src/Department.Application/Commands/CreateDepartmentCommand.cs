using Department.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.Application.Commands
{
    public class CreateDepartmentCommand:IRequest<bool>
    {
        public DepartmentDTO DepartmentDTO { get; set; }
    }
}

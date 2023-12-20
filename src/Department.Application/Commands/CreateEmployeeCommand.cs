using Department.Application.DTOs;
using MediatR;

namespace Department.Application.Commands
{
    public class CreateEmployeeCommand :IRequest<bool>
    {
        public EmployeeDTO Employee { get; set; }
    }
}

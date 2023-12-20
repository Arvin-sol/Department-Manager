using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.Application.DTOs
{
    public record EmployeeDTO
        (
        string Name,
        decimal Salary,
        DateTime BirthDay,
        int Department
        );
}

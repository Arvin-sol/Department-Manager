using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.Application.DTOs
{
    public record DepartmentDTO
        (
        string Name,
        string Location,
        decimal budget,
        int ID
        );
}

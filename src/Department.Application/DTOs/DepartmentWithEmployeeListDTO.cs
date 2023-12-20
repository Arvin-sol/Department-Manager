using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.Application.DTOs
{
    public class DepartmentWithEmployeeListDTO
    {
        public IEnumerable<string> DepartmentName { get; set; }
        public IEnumerable<EmployeeDTO> Employees { get; set; }
    }
}

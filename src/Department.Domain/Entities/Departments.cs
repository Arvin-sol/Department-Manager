using Department.Domain.Comman;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.Domain.Entities
{
    public class Departments:BaseEntity
    {
        [MaxLength(10)]
        public string DepartmentName { get; set; }
        public string Location { get; set; }
        public decimal Budget { get; set; }
        public string FlagSRC { get; set; }

        public IEnumerable<Employee> Employees { get; set; }
    }
}

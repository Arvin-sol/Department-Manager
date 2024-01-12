using Department.Domain.Comman;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.Domain.Entities
{
    public class Employee:BaseEntity
    {
        [MaxLength(100)]
        public required string Name { get; set; }
        public decimal Salary { get; set; }
        public DateTime BirthDay { get; set; }

        public int DepartmentID { get; set; }
        public virtual Departments Department { get; set; }
    }
}

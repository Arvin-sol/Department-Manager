using Department.Application.DTOs;
using Department.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.Application.Common
{
    public static class CustomMapper
    {
        public static EmployeeDTO ConvertToEmployeeDTO(this Employee model)
        {
            return new EmployeeDTO
                (
                model.Name,
                model.Salary,
                model.BirthDay,
                model.DepartmentID
                );
        }
    }
}

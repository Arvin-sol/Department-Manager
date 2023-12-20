using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.Application.Commands
{
    public class UpdatingDepartmentCommand:IRequest<bool>
    {
        public int ID { get; set; }
        public decimal Budget { get; set; }
        public string FlagSRC { get; set; }
    }
}

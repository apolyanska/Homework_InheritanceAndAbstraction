using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    public interface IEmployee
    {
         decimal Salary { get; set; }
         Department Department { get; set; }

    }
}

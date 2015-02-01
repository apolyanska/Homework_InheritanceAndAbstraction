using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy.Persons.Employees.RegularEmployees.SalesEmployees
{
    public interface ISalesEmployee
    {
        List<Sales> SalesSet { get; set; }
    }
}

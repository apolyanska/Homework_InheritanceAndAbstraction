using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy.Persons.Employees.RegularEmployees
{
    public abstract class RegularEmployee: Employee, IRegularEmployee
    {
        public RegularEmployee (int regularEmployeeID, string regularEmployeeFirstName,
            string regularEmployeeLastName, decimal regularEmployeeSalary, Department regularEmployeeDepartment)

            : base(regularEmployeeID, regularEmployeeFirstName, regularEmployeeLastName, regularEmployeeSalary, 
            regularEmployeeDepartment)
        {   
        } 
        public Employee regularEmployee { get; set; }
    }
}

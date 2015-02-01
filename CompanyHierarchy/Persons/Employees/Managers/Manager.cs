using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    public class Manager: Employee, IManager
    {
        private List<Employee> employeeSet;

        public Manager
            (int managerID, string managerFirstName, string managerLastName, decimal managerSalary, 
            Department managerDepartment, List<Employee> employeesUnderCommand)
            
            : base(managerID, managerFirstName, managerLastName, managerSalary, managerDepartment)
        {
            this.ЕmployeeSet = employeesUnderCommand;
        }


        public List<Employee> ЕmployeeSet
        {
            get
            {
                return this.employeeSet;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("List of employees cannot be empty!");
                }
                this.employeeSet = value;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    public abstract class Employee : Person, IEmployee
    {
       private decimal salary;
        public Employee
            (int employeeID, string employeeFirstName, string employeeLastName, decimal employeeSalary, Department employeeDepartment)
            : base(employeeID, employeeFirstName, employeeLastName)
        {
            this.Salary = employeeSalary;
            this.Department = employeeDepartment;
        }


        public decimal Salary
        {
            get { return this.salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Salary cannot be negative!");
                }
                this.salary = value;
            }
        }

      public Department Department { get; set; }
    }
}

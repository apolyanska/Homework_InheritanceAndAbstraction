using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy.Persons.Employees.RegularEmployees.SalesEmployees
{

    public class SalesEmployee : RegularEmployee, ISalesEmployee
    {
        private List<Sales> salesSet;

        public SalesEmployee(int salesEmployeeID, string salesEmployeeFirstName, string salesEmployeeLastName,
            decimal salesEmployeeSalary, Department salesEmployeeDepartment, List<Sales> sales)

            : base(salesEmployeeID, salesEmployeeFirstName, salesEmployeeLastName,
            salesEmployeeSalary, salesEmployeeDepartment)
        {
            this.SalesSet = sales;
        }

        public List<Sales> SalesSet
        {
            get { return this.salesSet; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The list of sales cannot be empty!");
                }
                this.salesSet = value;
            }
        }
    }
}

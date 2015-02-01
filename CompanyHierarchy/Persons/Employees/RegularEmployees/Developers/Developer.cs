using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyHierarchy.Persons.Employees.RegularEmployees.Developers.Projects;


namespace CompanyHierarchy.Persons.Employees.RegularEmployees.Developers
{
    class Developer: RegularEmployee, IDeveloper
    {
        private List<Project> projectSet;

        public Developer(int developerID, string developerFirstName, string developerLastName,
            decimal developerSalary, Department developerDepartment, List<Project> developerProjectSet)

            : base(developerID, developerFirstName, developerLastName, developerSalary, developerDepartment)
        {
            this.ProjectSet = developerProjectSet;
        }

        public List<Project> ProjectSet
        {
            get { return this.projectSet; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("List of projects cannot be empty!");
                }
                this.projectSet = value;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyHierarchy.Persons.Employees.RegularEmployees.Developers.Projects;

namespace CompanyHierarchy.Persons.Employees.RegularEmployees.Developers
{
    public interface IDeveloper
    {
        List<Project> ProjectSet { get; set; }
       // ProjectState CloseProject(); //==========================
    }
}

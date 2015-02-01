using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy.Persons.Employees.RegularEmployees.Developers.Projects
{
    public class Project
    {
        private string name;
        private DateTime startDate;
        private string details;
        public string State { get; set; }

        public Project(string projectName, DateTime projectStartDate, string projectDetails, ProjectState projectState)
        {
            this.Name = projectName;
            this.StartDate = projectStartDate;
            this.Details = projectDetails;
            this.State = CloseProject(projectState);
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Project name cannot be empty!");
                }
                this.name = value;
            }
        }
        public DateTime StartDate
        {
            get { return this.startDate; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The project must have valid start date!");
                }
                this.startDate = value;
            }
        }
        public string Details
        {
            get { return this.details; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Project must have details!");
                }
                this.details = value;
            }
        }
        public string CloseProject(ProjectState setProjectState)
        {
            string projectState = "Status: closed";
            if (setProjectState == ProjectState.open)
            {
                projectState = "Status: open";
            }
            return projectState;
        }
    }
}

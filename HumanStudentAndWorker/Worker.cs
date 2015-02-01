using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HumanStudentAndWorker
{
    public class Worker : Human // IEnumerable<Worker>
    {
        private decimal weekSalary;
        private decimal workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Week salary cannot be negative!");
                }
                this.weekSalary = value;
            }
        }
        public decimal WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value < 0 || value > 24)
                {
                    throw new ArgumentOutOfRangeException("Work hours must be in range 0 ... 24!");
                }
                this.workHoursPerDay = value;
            }
        }

        public decimal CalculateMoneyPerHour()
        {
            const int workDays = 5;
            decimal moneyPerHour = this.weekSalary / (this.workHoursPerDay * workDays);
            return moneyPerHour;
        }

        public override string ToString()
        {

            return String.Format("Name: {0} {1}, money per hour: {2}", this.FirstName, this.LastName, this.CalculateMoneyPerHour());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    public class Worker : Human, IWorker

    {
        private double weekSalary;
        private double workHoursPerDay;

        public Worker(string firstName, string lastName, double weekSalary, int workHoursPerDay) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double WeekSalary
        {
            get
            {
                return this.weekSalary;
            }

            set
            {
                this.weekSalary=value;
            }
        }

        public double WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }

            set
            {
               this.workHoursPerDay=value;
            }
        }

        public double MoneyPerHour()
        {
            double moneyPerDay = this.WeekSalary / 5;
            double money = moneyPerDay / this.WorkHoursPerDay;
            return money;
        }
    }

    internal interface IWorker
    {
        double WeekSalary { get; set; }
        double WorkHoursPerDay { get; set; }
        double MoneyPerHour();
    }
}

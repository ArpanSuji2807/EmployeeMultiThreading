using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayRollMultiThreading
{
    public class EmployeeDetails
    {
        private object startDate;

        public EmployeeDetails(int Id, string Name, int PhoneNumber, int Salary, string Gender, object StartDate, string Department, int Deduction, int Taxable_Pay, int Net_Pay)
        {
            this.Id = Id;
            this.Name = Name;
            this.PhoneNumber = PhoneNumber;
            this.Salary = Salary;
            this.Gender = Gender;
            startDate = StartDate;
            this.Department = Department;
            this.Deduction = Deduction;
            this.Taxable_Pay = Taxable_Pay;
            this.Net_Pay = Net_Pay;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public DateTime Startdate { get; set; }
        public string Gender { get; set; }
        public int PhoneNumber { get; set; }
        public string Department { get; set; }
        public double Deduction { get; set; }
        public double Taxable_Pay { get; set; }
        public double Net_Pay { get; set; }
    }
}

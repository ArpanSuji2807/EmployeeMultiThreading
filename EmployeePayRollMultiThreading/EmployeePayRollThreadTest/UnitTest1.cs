using EmployeePayRollMultiThreading;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace EmployeePayRollThreadTest
{
    public class Tests
    {
        [Test]
        public void Given5Employee_WhenAddedToList_ShouldMatchmployeeEntries()
        {
            List<EmployeeDetails> list = new List<EmployeeDetails>();
            list.Add(new EmployeeDetails(Id: 2, Name: "Arpan", PhoneNumber: 888999878, Salary: 20000, Gender: "M", StartDate: DateTime.Now, Department: "Marketing", Deduction: 2000, Taxable_Pay: 3000, Net_Pay: 50000));
            list.Add(new EmployeeDetails(Id: 2, Name: "Rajen", PhoneNumber: 8882555, Salary: 20000, Gender: "M", StartDate: DateTime.Now, Department: "Marketing", Deduction: 2000, Taxable_Pay: 3000, Net_Pay: 50000));
            list.Add(new EmployeeDetails(Id: 2, Name: "Ravi", PhoneNumber: 88892547, Salary: 20000, Gender: "M", StartDate: DateTime.Now, Department: "Sales", Deduction: 2000, Taxable_Pay: 3000, Net_Pay: 50000));
            list.Add(new EmployeeDetails(Id: 2, Name: "Raju", PhoneNumber: 83634565, Salary: 20000, Gender: "M", StartDate: DateTime.Now, Department: "Development", Deduction: 2000, Taxable_Pay: 3000, Net_Pay: 50000));
            list.Add(new EmployeeDetails(Id: 2, Name: "Stephen", PhoneNumber: 888956464, Salary: 20000, Gender: "M", StartDate: DateTime.Now, Department: "Sales", Deduction: 2000, Taxable_Pay: 3000, Net_Pay: 50000));
            EmployeePayRollOperations operations = new EmployeePayRollOperations();
            DateTime startDateTime = DateTime.Now;
            operations.AddEmployeePayRoll(list);
            DateTime stopDateTime = DateTime.Now;
            Console.WriteLine("Duration without thread:- " + (stopDateTime - startDateTime));

            DateTime startDateTimeThread = DateTime.Now;
            operations.AddEmployeePayRollThread(list);
            DateTime stopDateTimeThread = DateTime.Now;
            Console.WriteLine("Duration with thread:- " + (stopDateTimeThread - startDateTimeThread));
        }
    }
}
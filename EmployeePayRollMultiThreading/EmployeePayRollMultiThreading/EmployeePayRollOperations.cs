using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayRollMultiThreading
{
    public class EmployeePayRollOperations
    {
        public List<EmployeeDetails> list = new List<EmployeeDetails>();
        public void AddEmployeePayRoll(List<EmployeeDetails> list)
        {
            list.ForEach(employeeData =>
            {
                Console.WriteLine("Employee being added: " + employeeData.Name);
                this.list.Add(employeeData);
            }
            );
            Console.WriteLine(this.list.ToString());
        }
        public void AddEmployeePayRollThread(List<EmployeeDetails> list)
        {
            list.ForEach(employeeData =>
            {
                Task thread = new Task(() =>
                {
                    Console.WriteLine("Employee being added: " + employeeData.Name);
                    this.list.Add(employeeData);
                }
            );
                thread.Start();
            });
            Console.WriteLine(this.list.Count());
        }
    }
}
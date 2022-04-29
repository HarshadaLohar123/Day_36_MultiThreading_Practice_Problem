using System;
using System.Collections.Generic;

namespace EmployeePayroll_Threading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<EmployeeDetails> employeeDetails = new List<EmployeeDetails>();
            employeeDetails.Add(new EmployeeDetails { EmpID = 1, EmpName = "Raj", PhoneNo = "5808983789", Address = "Mumbai", Department = "IT", Gender = "Male" });
            employeeDetails.Add(new EmployeeDetails { EmpID = 2, EmpName = "Mayur", PhoneNo = "8521479630", Address = "Pune", Department = "HR", Gender = "Male" });
            employeeDetails.Add(new EmployeeDetails { EmpID = 3, EmpName = "Sanjay", PhoneNo = "1234568798", Address = "Mumbai", Department = "SALES", Gender = "Male" });
            employeeDetails.Add(new EmployeeDetails { EmpID = 4, EmpName = "Rohan", PhoneNo = "9655555476", Address = "Chennai", Department = "HR", Gender = "Male" });
            EmployeePayrollOperations employeePayrolloperations = new EmployeePayrollOperations();
            // UC 1
            DateTime startDateTime = DateTime.Now;
            employeePayrolloperations.addEmployeeToPayroll(employeeDetails);
            DateTime stopDateTime = DateTime.Now;
            Console.WriteLine("Duration without thread: " + (stopDateTime - startDateTime));
        }
    }
}

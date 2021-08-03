using System;
using System.Collections.Generic;

namespace Adapter
{
    /// <summary>
    /// Object Adapter Pattern
    /// </summary>
    public class EmployeeAdapter : ITarget
    {
        ThirdPartyBillingSystem thirdPartyBillingSystem = new ThirdPartyBillingSystem();

        public void ProcessCompanySalary(string[,] employeesArray)
        {
            string Id = null;
            string Name = null;
            string Designation = null;
            string Salary = null;
            List<Employee> listEmployee = new List<Employee>();
            for (int i = 0; i < employeesArray.GetLength(0); i++)
            {
                for (int j = 0; j < employeesArray.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        Id = employeesArray[i, j];
                    }
                    else if (j == 1)
                    {
                        Name = employeesArray[i, j];
                    }
                    else if (j == 1)
                    {
                        Designation = employeesArray[i, j];
                    }
                    else
                    {
                        Salary = employeesArray[i, j];
                    }
                }
                listEmployee.Add(new Employee(Convert.ToInt32(Id), Name, Designation, Convert.ToDecimal(Salary)));
            }
            Console.WriteLine("Adapter converted Array of Employee to List of Employee");
            Console.WriteLine("Then delegate to the ThirdPartyBillingSystem for processing the employee salary\n");
            thirdPartyBillingSystem.ProcessSalary(listEmployee);
        }
    }

    /// <summary>
    /// Class Adapter Pattern
    /// </summary>
    //public class EmployeeAdapter : ThirdPartyBillingSystem, ITarget
    //{
    //    public void ProcessCompanySalary(string[,] employeesArray)
    //    {
    //        string Id = null;
    //        string Name = null;
    //        string Designation = null;
    //        string Salary = null;
    //        List<Employee> listEmployee = new List<Employee>();
    //        for (int i = 0; i < employeesArray.GetLength(0); i++)
    //        {
    //            for (int j = 0; j < employeesArray.GetLength(1); j++)
    //            {
    //                if (j == 0)
    //                {
    //                    Id = employeesArray[i, j];
    //                }
    //                else if (j == 1)
    //                {
    //                    Name = employeesArray[i, j];
    //                }
    //                else if (j == 1)
    //                {
    //                    Designation = employeesArray[i, j];
    //                }
    //                else
    //                {
    //                    Salary = employeesArray[i, j];
    //                }
    //            }
    //            listEmployee.Add(new Employee(Convert.ToInt32(Id), Name, Designation, Convert.ToDecimal(Salary)));
    //        }
    //        Console.WriteLine("Adapter converted Array of Employee to List of Employee");
    //        Console.WriteLine("Then delegate to the ThirdPartyBillingSystem for processing the employee salary\n");
    //        ProcessSalary(listEmployee);
    //    }
    //}
}

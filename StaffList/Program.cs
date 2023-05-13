using System;
using System.Linq;
using System.Collections.Generic;

namespace StaffList
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Staff> staffs = new List<Staff>();

            for (int i = 0; i < n; i++)
            {
                string[] staffData = Console.ReadLine().Split();
                string name = staffData[0];
                double salary = double.Parse(staffData[1]);
                string position = staffData[2];
                string department = staffData[3];
                string email = "n/a";
                int age = -1;

                if (staffData.Length > 4)
                {
                    if (staffData[4].Contains("@"))
                    {
                        email = staffData[4];
                    }
                    else
                    {
                        age = int.Parse(staffData[4]);
                    }
                }
                if (staffData.Length > 5)
                {
                    age = int.Parse(staffData[5]);
                }

                staffs.Add(new Staff(name, salary, position, department, email, age));
            }

            var highestAvgSalaryDep = staffs
                .GroupBy(e => e.Department)
                .Select(g => new
                {
                    Department = g.Key,
                    AverageSalary = g.Average(e => e.Salary)
                })
                .OrderByDescending(g => g.AverageSalary)
                .First();

            Console.WriteLine($"Highest Average Salary: {highestAvgSalaryDep.Department}");

            foreach (Staff staff in staffs.Where(e => e.Department == highestAvgSalaryDep.Department)
                                              .OrderByDescending(e => e.Salary))
            {
                Console.WriteLine(staff);
            }
        }
    }
}
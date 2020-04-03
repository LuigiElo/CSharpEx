using System;
using System.Collections.Generic;

namespace DNPExamPt2.Data
{
    public class EmployeeService
    {

        public List<Employee> FilterEmployeesBasedOnOvertime(List<Employee> employees,Boolean hasOvertime)
        {
            List<Employee> overtime = new List<Employee>();
            if (hasOvertime == true)
            {
                for (int i = 0; i < employees.Count; i++)
                {
                    if (employees[i].HoursPerMonth > 150)
                    {
                        overtime.Add(employees[i]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < employees.Count; i++)
                {
                    if (employees[i].HoursPerMonth <= 150)
                    {
                        overtime.Add(employees[i]);
                    }
                }
            }

            return overtime;
        }
        
        public double GetTotalMonthlyExpense(List<Employee> employees)
        {
            double total = 0;
            for (int i = 0; i < employees.Count; i++)
            {
                total += employees[i].GetMonthlyPay();
            }

            return total;
        }
        
        
    }
}
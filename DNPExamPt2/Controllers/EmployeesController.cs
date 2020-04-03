using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DNPExamPt2.Data;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DNPExamPt2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : ControllerBase
    {
     
        private readonly EmployeesContext _employeesContext;
        private EmployeeService _employeeService = new EmployeeService();

        public EmployeesController(EmployeesContext _employeesContext)
        {
            this._employeesContext = _employeesContext;
        }
        
        
        //Get the list of employees based in overtime
        [HttpGet("employees")]
        public async Task<List<Employee>> Employees(Boolean hasOvertime)
        {
            List<Employee> temporary = new List<Employee>();
            for (int i = 0; i < _employeesContext.Employees.Count(); i++)
            {
                temporary.Add( _employeesContext.Employees.Find(i+1));
                Console.WriteLine(_employeesContext);
            }

            var final = _employeeService.FilterEmployeesBasedOnOvertime(temporary, hasOvertime);
            return final;
        }

        
        //add a new Employee
        [HttpPost("employees")]
        public async Task<string> Employees(Employee employee)
        {
            var e = employee;
            Console.WriteLine(e.Id);
             _employeesContext.Employees.Add(e);
             await _employeesContext.SaveChangesAsync();
            return "Done";
        }

        //Get the total of payments based on overtime
        [HttpGet("payments")]
        public async Task<double> Payments(Boolean hasOvertime)
        {
            List<Employee> temporary = new List<Employee>();
            for (int i = 0; i < _employeesContext.Employees.Count(); i++)
            {
                temporary.Add( _employeesContext.Employees.Find(i+1));
            }

            var list = _employeeService.FilterEmployeesBasedOnOvertime(temporary, hasOvertime);
            var final = _employeeService.GetTotalMonthlyExpense(list);
            return final; 
        }
        
        
        
        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DNPExamPt2.Data;
using EmployeeWeb.Controller;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace EmployeeWeb.Pages
{
    public class PrivacyModel : PageModel
    {
        public List<Employee> Regular = new List<Employee>();
        public List<Employee> Overtime = new List<Employee>();
        
        
        public double totalRegular = 0;
        public double totalOvertime = 0 ;
        public double total = 0;
        
        

        
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            RequestManager rm = new RequestManager();
            Overtime = rm.Get("https://localhost:5001/employees/employees?hasOvertime=true").Result;
            Regular = rm.Get("https://localhost:5001/employees/employees?hasOvertime=false").Result;
            totalOvertime = rm.GetTotal("https://localhost:5001/employees/payments?hasOvertime=true").Result;
            totalRegular = rm.GetTotal("https://localhost:5001/employees/payments?hasOvertime=false").Result;
                total = totalOvertime + totalRegular;

        }
    }
}
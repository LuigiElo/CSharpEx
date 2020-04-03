using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using DNPExamPt2.Data;
using EmployeeWeb.Controller;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace EmployeeWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [BindProperty] [Required] public string Name { get; set; }

        [BindProperty] [Required] public double HourlyWage { get; set; }

        [BindProperty] [Required] public double HoursPerMonth { get; set; }



        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            RequestManager rm = new RequestManager();



            if (ModelState.IsValid)
            {
                Employee e = new Employee();
                e.Name = Name;
                e.HourlyWage = HourlyWage;
                e.HoursPerMonth = HoursPerMonth;
                rm.Post("https://localhost:5001/employees/employees", e);
            }
            return RedirectToPage("Index");
        }
    }

}
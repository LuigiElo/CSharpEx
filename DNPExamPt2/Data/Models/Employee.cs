using System.ComponentModel.DataAnnotations;

namespace DNPExamPt2.Data
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        [Required]

        public double HourlyWage { get; set; }
        
        public double HoursPerMonth { get; set; }

        public double GetMonthlyPay()
        {
            double total = 0;
            if (HoursPerMonth > 150)
            {
               
               total = (HoursPerMonth - 150) * 1.5 * HourlyWage + 150 * HourlyWage;
            }
            else
            {
                total = HoursPerMonth * HourlyWage;
            }

            return total;
        }
    }
}
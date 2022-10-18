using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Shared.Models.WageServices
{
    public class PostTaxDeduction
    {
        [Required]
        public decimal Roth401KPercentage { get; set; }
        [Required]
        public decimal EmployeeStockPlan { get; set; }
        [Required]
        public Dictionary<string, decimal> OtherDeductions { get; set; }
    }
}

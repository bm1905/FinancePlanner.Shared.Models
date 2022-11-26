using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FinancePlanner.Shared.Models.WageServices;

public class PostTaxDeductionRequest
{
    [Required]
    public decimal Roth401KPercentage { get; set; }
    [Required]
    public decimal EmployeeStockPlan { get; set; }
    [Required] 
    public Dictionary<string, decimal> OtherDeductions { get; set; } = new();
    [Required]
    public decimal TotalGrossPay { get; set; }
}
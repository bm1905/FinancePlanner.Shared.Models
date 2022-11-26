using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FinancePlanner.Shared.Models.WageServices;

public class PostTaxDeductionResponse
{
    [Required]
    public decimal Roth401KPercentage { get; set; }
    [Required]
    public decimal EmployeeStockPlan { get; set; }
    [Required] 
    public Dictionary<string, decimal> OtherDeductions { get; set; } = new();
    public decimal TotalPostTaxDeductions { get; set; }
    public decimal TotalGrossPay { get; set; }
}
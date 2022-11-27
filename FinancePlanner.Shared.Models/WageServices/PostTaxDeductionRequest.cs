using FinancePlanner.Shared.Models.Common;

namespace FinancePlanner.Shared.Models.WageServices;

public class PostTaxDeductionRequest
{
    public decimal TotalGrossPay { get; set; }
    public PostTaxDeductionDto PostTaxDeduction { get; set; } = new();
}
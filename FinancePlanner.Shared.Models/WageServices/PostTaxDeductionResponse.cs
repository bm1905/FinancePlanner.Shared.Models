using FinancePlanner.Shared.Models.Common;

namespace FinancePlanner.Shared.Models.WageServices;

public class PostTaxDeductionResponse
{
    public decimal TotalGrossPay { get; set; }
    public decimal TotalPostTaxDeductionAmount { get; set; }
    public PostTaxDeductionDto PostTaxDeduction { get; set; } = new();
}

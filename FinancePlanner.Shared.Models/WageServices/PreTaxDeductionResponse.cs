using FinancePlanner.Shared.Models.Common;

namespace FinancePlanner.Shared.Models.WageServices;

public class PreTaxDeductionResponse
{
    public decimal GrossPay { get; set; }
    public decimal TotalPreTaxDeductionAmount { get; set; }
    public TaxableWageInformationDto TaxableWageInformation { get; set; } = new();
}
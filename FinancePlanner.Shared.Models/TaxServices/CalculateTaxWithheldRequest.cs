using FinancePlanner.Shared.Models.Common;

namespace FinancePlanner.Shared.Models.TaxServices;

public class CalculateTaxWithheldRequest
{
    public TaxInformationDto TaxInformation { get; set; } = new();
    public TaxableWageInformationDto TaxableWageInformation { get; set; } = new();
}
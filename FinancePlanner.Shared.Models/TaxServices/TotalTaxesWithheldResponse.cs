using FinancePlanner.Shared.Models.Common;

namespace FinancePlanner.Shared.Models.TaxServices;

public class TotalTaxesWithheldResponse
{
    public TaxWithheldInformationDto TaxWithheldInformation { get; set; } = new();
    public TaxableWageInformationDto TaxableWageInformation { get; set; } = new();
}
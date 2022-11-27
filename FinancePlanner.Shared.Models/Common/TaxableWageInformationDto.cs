namespace FinancePlanner.Shared.Models.Common;

/// <summary>
/// Taxable wages
/// </summary>
public class TaxableWageInformationDto
{
    public decimal StateAndFederalTaxableWages { get; set; }
    public decimal SocialAndMedicareTaxableWages { get; set; }
}
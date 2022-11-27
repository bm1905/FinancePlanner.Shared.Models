namespace FinancePlanner.Shared.Models.Common;

/// <summary>
/// Total taxes withheld
/// </summary>
public class TaxWithheldInformationDto
{
    public decimal FederalTaxWithheldAmount { get; set; }
    public decimal MedicareWithheldAmount { get; set; }
    public decimal SocialSecurityWithheldAmount { get; set; }
    public decimal StateTaxWithheldAmount { get; set; }
    public decimal TotalTaxesWithheldAmount { get; set; }
}
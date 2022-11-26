namespace FinancePlanner.Shared.Models.TaxServices;

public class TotalTaxesWithheldResponse
{
    public decimal FederalTaxableWage { get; set; }
    public decimal MedicareTaxableWage { get; set; }
    public decimal SocialSecurityTaxableWage { get; set; }
    public decimal FederalTaxWithheldAmount { get; set; }
    public decimal MedicareWithheldAmount { get; set; }
    public decimal SocialSecurityWithheldAmount { get; set; }
    public decimal StateTaxWithheldAmount { get; set; }
    public decimal TotalTaxesWithheldAmount { get; set; }
}
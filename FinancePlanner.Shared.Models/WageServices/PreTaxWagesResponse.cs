namespace FinancePlanner.Shared.Models.WageServices;

public class PreTaxWagesResponse
{
    public decimal GrossPay { get; set; }
    public decimal TotalPreTaxDeductions { get; set; }
    public decimal StateAndFederalTaxableWages { get; set; }
    public decimal SocialAndMedicareTaxableWages { get; set; }
}
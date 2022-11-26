using FinancePlanner.Shared.Models.Enums;

namespace FinancePlanner.Shared.Models.FinanceServices;

public class TaxInformationDto
{
    public W4Type W4Type { get; set; }
    public TaxFilingStatus TaxFilingStatus { get; set; }
    public int PayPeriodNumber { get; set; }
    public string State { get; set; } = string.Empty;
    public bool IsMultipleJobsChecked { get; set; }
    public decimal ExtraWithholdingAmount { get; set; }
    public decimal DeductionsAmount { get; set; }
    public decimal OtherIncomeAmount { get; set; }
    public decimal ClaimDependentsAmount { get; set; }
}
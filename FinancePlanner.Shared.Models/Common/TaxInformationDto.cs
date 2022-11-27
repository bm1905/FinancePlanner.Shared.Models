using FinancePlanner.Shared.Models.Enums;

namespace FinancePlanner.Shared.Models.Common;

/// <summary>
/// Tax information; from W4
/// </summary>
public class TaxInformationDto
{
    // Common
    public W4Type W4Type { get; set; }
    public TaxFilingStatus TaxFilingStatus { get; set; }
    public int PayPeriodNumber { get; set; }
    public string State { get; set; } = string.Empty;
    public decimal ExtraWithholdingAmount { get; set; }

    // W4 Before 2020
    public int? AllowanceNumber { get; set; }

    // W4 From or After 2020
    public bool? IsMultipleJobsChecked { get; set; }
    public decimal? DeductionsAmount { get; set; }
    public decimal? OtherIncomeAmount { get; set; }
    public decimal? ClaimDependentsAmount { get; set; }
}
namespace FinancePlanner.Shared.Models.Common;

/// <summary>
/// Income information including gross/net pay, hours, rate, pre-post deductions, taxable wages and tax amount.
/// </summary>
public class IncomeInformationDto
{
    public decimal GrossPay { get; set; }
    public decimal NetPay { get; set; }
    public decimal TotalHours { get; set; }
    public decimal PayRate { get; set; }
    public decimal TotalPreTaxDeductions { get; set; }
    public decimal TotalPostTaxDeductions { get; set; }
    public TaxableWageInformationDto TaxableWageInformation { get; set; } = new();
    public TaxWithheldInformationDto TaxWithheldInformation { get; set; } = new();
}
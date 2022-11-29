using FinancePlanner.Shared.Models.Common;

namespace FinancePlanner.Shared.Models.FinanceServices;

public class IncomeInformationRequest
{
    public string UserId { get; set; } = string.Empty;
    public string EmployeeName { get; set; } = string.Empty;
    public int PayInformationId { get; set; }
    public decimal GrossPay { get; set; }
    public decimal NetPay { get; set; }
    public decimal TotalHours { get; set; }
    public decimal PayRate { get; set; }
    public decimal TotalPreTaxDeductions { get; set; }
    public decimal TotalPostTaxDeductions { get; set; }
    public TaxableWageInformationDto TaxableWageInformation { get; set; } = new();
    public TaxWithheldInformationDto TaxWithheldInformation { get; set; } = new();
}
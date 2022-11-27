using FinancePlanner.Shared.Models.Common;

namespace FinancePlanner.Shared.Models.FinanceServices;

public class PayInformationRequest
{
    public string EmployeeName { get; set; } = string.Empty;
    public BiWeeklyHoursAndRateDto BiWeeklyHoursAndRate { get; set; } = new();
    public PreTaxDeductionDto PreTaxDeduction { get; set; } = new();
    public PostTaxDeductionDto PostTaxDeduction { get; set; } = new();
    public TaxInformationDto TaxInformation { get; set; } = new();
}
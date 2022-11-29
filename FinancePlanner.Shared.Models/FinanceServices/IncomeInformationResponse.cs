using FinancePlanner.Shared.Models.Common;

namespace FinancePlanner.Shared.Models.FinanceServices;

public class IncomeInformationResponse
{
    public int IncomeInformationId { get; set; }
    public string UserId { get; set; } = string.Empty;
    public string EmployeeName { get; set; } = string.Empty;
    public int PayInformationId { get; set; }
    public IncomeInformationDto IncomeInformation { get; set; } = new();
}
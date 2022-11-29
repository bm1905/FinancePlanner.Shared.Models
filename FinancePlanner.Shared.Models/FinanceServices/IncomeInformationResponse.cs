using FinancePlanner.Shared.Models.Common;

namespace FinancePlanner.Shared.Models.FinanceServices;

public class IncomeInformationResponse
{
    public int IncomeInformationId { get; set; }
    public IncomeInformationDto IncomeInformation { get; set; } = new();
}
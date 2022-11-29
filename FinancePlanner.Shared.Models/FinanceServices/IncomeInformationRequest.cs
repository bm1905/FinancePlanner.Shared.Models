using FinancePlanner.Shared.Models.Common;

namespace FinancePlanner.Shared.Models.FinanceServices;

public class IncomeInformationRequest
{
    public IncomeInformationDto IncomeInformation { get; set; } = new();
}
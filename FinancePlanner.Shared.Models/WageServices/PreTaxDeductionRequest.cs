using System.Collections.Generic;
using FinancePlanner.Shared.Models.Common;

namespace FinancePlanner.Shared.Models.WageServices;

public class PreTaxDeductionRequest
{
    public List<WeeklyHoursAndRateDto> WeeklyHoursAndRate { get; set; } = new();
    public PreTaxDeductionDto PreTaxDeduction { get; set; } = new();
}


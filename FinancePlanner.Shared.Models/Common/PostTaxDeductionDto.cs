namespace FinancePlanner.Shared.Models.Common;

/// <summary>
/// Post tax deductions
/// </summary>
public class PostTaxDeductionDto
{
    public decimal Roth401KPercentage { get; set; }
    public decimal EmployeeStockPlanAmount { get; set; }
    public decimal AccidentInsuranceAmount { get; set; }
    public decimal LifeInsuranceAmount { get; set; }
    public decimal MiscellaneousAmount { get; set; }
}
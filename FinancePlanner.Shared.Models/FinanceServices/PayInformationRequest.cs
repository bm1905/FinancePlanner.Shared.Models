using FinancePlanner.Shared.Models.Enums;
using System.Collections.Generic;

namespace FinancePlanner.Shared.Models.FinanceServices;

public class PayInformationRequest
{
    public string EmployeeName { get; set; } = string.Empty;
    public BiWeeklyHoursAndRate BiWeeklyHoursAndRate { get; set; } = new();
    public PreTaxDeduction PreTaxDeduction { get; set; } = new();
    public PostTaxDeduction PostTaxDeduction { get; set; } = new();
    public TaxInformation TaxInformation { get; set; } = new();
}

public class BiWeeklyHoursAndRate
{
    public decimal HourlyRateWeek1 { get; set; }
    public decimal TotalHoursWeek1 { get; set; }
    public decimal TimeOffHoursWeek1 { get; set; }
    public decimal HourlyRateWeek2 { get; set; }
    public decimal TotalHoursWeek2 { get; set; }
    public decimal TimeOffHoursWeek2 { get; set; }
}

public class PreTaxDeduction
{
    public decimal Medical { get; set; }
    public decimal Dental { get; set; }
    public decimal Vision { get; set; }
    public decimal Traditional401KPercentage { get; set; }
    public decimal HealthSavingAccountAmount { get; set; }
    public decimal MiscellaneousAmount { get; set; }
}

public class PostTaxDeduction
{
    public decimal Roth401KPercentage { get; set; }
    public decimal EmployeeStockPlanAmount { get; set; }
    public decimal AccidentInsuranceAmount { get; set; }
    public decimal LifeInsuranceAmount { get; set; }
    public decimal MiscellaneousAmount { get; set; }
}

public class TaxInformation
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
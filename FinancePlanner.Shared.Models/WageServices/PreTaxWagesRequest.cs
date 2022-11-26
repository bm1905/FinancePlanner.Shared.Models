using System.Collections.Generic;

namespace FinancePlanner.Shared.Models.WageServices;

public class PreTaxWagesRequest
{
    public List<WeeklyHour> WeeklyHours { get; set; } = new();
    public decimal Medical { get; set; }
    public decimal Dental { get; set; }
    public decimal Vision { get; set; }
    public decimal Traditional401KPercentage { get; set; }
    public decimal HealthSavingAccount { get; set; }
    public decimal Others { get; set; }
}

public class WeeklyHour
{
    public decimal TotalHours { get; set; }
    public decimal TimeOffHours { get; set; }
    public decimal HourlyRate { get; set; }
}
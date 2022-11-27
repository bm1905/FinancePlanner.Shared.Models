namespace FinancePlanner.Shared.Models.Common;

/// <summary>
/// Weekly time
/// </summary>
public class WeeklyHoursAndRateDto
{
    public decimal TotalHours { get; set; }
    public decimal TimeOffHours { get; set; }
    public decimal HourlyRate { get; set; }
}
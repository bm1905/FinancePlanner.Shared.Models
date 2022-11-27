namespace FinancePlanner.Shared.Models.Common;

/// <summary>
/// Biweekly time information
/// </summary>
public class BiWeeklyHoursAndRateDto
{
    public decimal HourlyRate { get; set; }
    public decimal Week1TotalHours { get; set; }
    public decimal Week1TimeOffHours { get; set; }
    public decimal Week2TotalHours { get; set; }
    public decimal Week2TimeOffHours { get; set; }
}
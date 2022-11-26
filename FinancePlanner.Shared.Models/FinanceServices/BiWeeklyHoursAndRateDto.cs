namespace FinancePlanner.Shared.Models.FinanceServices;

public class BiWeeklyHoursAndRateDto
{
    public decimal HourlyRate { get; set; }
    public decimal Week1TotalHours { get; set; }
    public decimal Week1TimeOffHours { get; set; }
    public decimal Week2TotalHours { get; set; }
    public decimal Week2TimeOffHours { get; set; }
}
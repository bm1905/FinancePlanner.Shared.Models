﻿namespace FinancePlanner.Shared.Models.Common;

/// <summary>
/// Pre tax deductions
/// </summary>
public class PreTaxDeductionDto
{
    public decimal Medical { get; set; }
    public decimal Dental { get; set; }
    public decimal Vision { get; set; }
    public decimal Traditional401KPercentage { get; set; }
    public decimal HealthSavingAccountAmount { get; set; }
    public decimal MiscellaneousAmount { get; set; }
}
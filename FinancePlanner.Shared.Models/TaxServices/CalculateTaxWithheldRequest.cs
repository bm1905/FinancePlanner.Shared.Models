using System.Collections.Generic;
using FinancePlanner.Shared.Models.Enums;

namespace FinancePlanner.Shared.Models.TaxServices
{
    public class CalculateTaxWithheldRequest
    {
        public string W4Type { get; set; } = string.Empty;
        public TaxFilingStatus TaxFilingStatus { get; set; }
        public decimal FederalTaxableWage { get; set; }
        public decimal StateTaxableWage { get; set; }
        public decimal MedicareTaxableWage { get; set; }
        public decimal SocialSecurityTaxableWage { get; set; }
        public int PayPeriodNumber { get; set; }
        public string State { get; set; } = string.Empty;
        public Dictionary<string, string> Data { get; set; } = new();
    }
}

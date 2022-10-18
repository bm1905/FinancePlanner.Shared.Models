using System.Collections.Generic;
using Shared.Models.Enums;

namespace Shared.Models.TaxServices
{
    public class CalculateTaxWithheldRequest
    {
        public string W4Type { get; set; }
        public TaxFilingStatus TaxFilingStatus { get; set; }
        public decimal FederalTaxableWage { get; set; }
        public decimal StateTaxableWage { get; set; }
        public decimal MedicareTaxableWage { get; set; }
        public decimal SocialSecurityTaxableWage { get; set; }
        public int PayPeriodNumber { get; set; }
        public string State { get; set; }
        public Dictionary<string, string> Data { get; set; }
    }
}

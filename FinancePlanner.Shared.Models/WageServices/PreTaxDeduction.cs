namespace Shared.Models.WageServices
{
    public class PreTaxDeduction
    {
        public decimal Medical { get; set; }
        public decimal Dental { get; set; }
        public decimal Vision { get; set; }
        public decimal Traditional401KPercentage { get; set; }
        public decimal HealthSavingAccount { get; set; }
        public decimal Others { get; set; }
    }
}

namespace Shared.Models.WageServices
{
    public class PostTaxDeductionResponse : PostTaxDeduction
    {
        public decimal TotalPostTaxDeductions { get; set; }
        public decimal TotalGrossPay { get; set; }
    }
}

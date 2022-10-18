using System.ComponentModel.DataAnnotations;

namespace Shared.Models.WageServices
{

    public class PostTaxDeductionRequest : PostTaxDeduction
    {
        [Required]
        public decimal TotalGrossPay { get; set; }
    }
}

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Shared.Models.WageServices
{
    public class PreTaxWagesRequest
    {
        [Required]
        public List<WeeklyHour> WeeklyHours { get; set; }
        [Required]
        public PreTaxDeduction PreTaxDeduction { get; set; }
    }
}

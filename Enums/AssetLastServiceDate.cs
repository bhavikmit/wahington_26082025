using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    public enum AssetLastServiceDate
    {
        [Display(Name = "1 Year")]
        OneYear = 1,
        [Display(Name = "2 Years")]
        TwoYears = 2,
        [Display(Name = "5 Years")]
        FiveYears = 5,
        [Display(Name = "10 Years")]
        TenYears = 10,
        [Display(Name = "15 Years")]
        FifteenYears = 15,
    }
}

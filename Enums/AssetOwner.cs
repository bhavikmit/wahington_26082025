using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    public enum AssetOwner
    {
        Engineering = 1,
        [Display(Name = "Field Ops")]
        FieldOps = 2,
        Integrity = 3,
        Policy = 4
    }
}

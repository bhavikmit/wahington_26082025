using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Enums
{
    public enum AssetCostCenter
    {
        [Display(Name = "CC-201")]
        CC201=1,

        [Display(Name = "CC-202")]
        CC202  =2,

        [Display(Name = "CC-203")]
        CC203  =3
    }
}

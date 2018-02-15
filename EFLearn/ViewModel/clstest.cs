using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EFLearn.ViewModel
{
    public class clstest
    {
        public List<M_DiscountType> discTypes { get; set; }

        [Required]
        public string strRequired { get; set; }
    }
}
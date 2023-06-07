using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GrapeCity.Forguncy.Plugin;

namespace UrlBuilder
{
    public class UrlParameter : ObjectPropertyBase
    {
        [FormulaProperty]
        [DisplayName("参数名")]
        public object Name { get; set; }

        [DisplayName("值")]
        [FormulaProperty]
        public object Value { get; set; }
    }
}

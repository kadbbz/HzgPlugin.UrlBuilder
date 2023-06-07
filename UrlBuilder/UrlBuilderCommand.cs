using GrapeCity.Forguncy.Commands;
using GrapeCity.Forguncy.Plugin;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace UrlBuilder
{
    [Icon("pack://application:,,,/UrlBuilder;component/Resources/Icon.png")]
    [Designer("UrlBuilder.Designer.UrlBuilderCommandDesigner, UrlBuilder")]
    public class UrlBuilderCommand : Command
    {
        [OrderWeight(100)]
        [DisplayName("当前应用内的页面名")]
        [FormulaProperty]
        public object PageName { get; set; }

        [OrderWeight(200)]
        [DisplayName("点击设置参数")]
        [ListProperty]
        public List<UrlParameter> UrlParamaterPairs { get; set; }

        [OrderWeight(999)]
        [DisplayName("将结果返回到变量")]
        [ResultToProperty]
        public String OutParamaterName { get; set; }


        public override string ToString()
        {
            if (String.IsNullOrEmpty(OutParamaterName))
            {
                return "在前端生成URL"; // 命令列表中默认显示的名称
            }
            else
            {
                return "在前端生成URL：" + OutParamaterName;
            }
        }
    }
}

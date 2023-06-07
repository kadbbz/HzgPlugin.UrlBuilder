using GrapeCity.Forguncy.Commands;
using System;
using System.Collections.Generic;

namespace UrlBuilder.Designer
{
    public class UrlBuilderCommandDesigner : CommandDesigner<UrlBuilderCommand>
    {
        public override IEnumerable<string> GetSearchTags()
        {
            return new string[] { "test" }; // 自定义命令的搜索关键字
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace FusionChartsCoreTest
{
    public class ChartTestUtility
    {
        public static string GetRenderedObjectNew()
        {
            return "<!-- Using ASP.NET FusionCharts Wrapper and JavaScript rendering --><!-- START Script Block for Chart myChart --><div id='myChart_div' >Chart...</div><script type=\"text/javascript\">FusionCharts && FusionCharts.ready(function () {if (FusionCharts(\"myChart\") ) FusionCharts(\"myChart\").dispose();var chart_myChart = new FusionCharts({\"type\":\"column3d\",\"width\":\"600\",\"height\":\"350\",\"renderAt\":\"myChart_div\",\"dataSource\":\"../Data/Data.json\",\"dataFormat\":\"jsonurl\"\"id\":\"myChart\"}).render();});</script><!-- END Script Block for Chart myChart -->";

        }
    }
}

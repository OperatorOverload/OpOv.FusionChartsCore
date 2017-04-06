using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FusionChartsCoreTest
{
    public class ChartObject_JSONTests
    {
        [Fact]
        public void TestLegacyReframeRender()
        {
            var expectedRender = ChartTestUtility.GetRenderedObjectNew().Trim().Replace(Environment.NewLine,"");
            var newChart = new FusionChartsCore.Legacy.LegacyChart("column3d", "myChart", "600", "350", "jsonurl", "../Data/Data.json");
            var renderedNew = newChart.Render().Trim().Replace(Environment.NewLine, "");

            Assert.Equal(expectedRender.Length, renderedNew.Length);
        }

        [Fact]
        public void TestNewReframeRender()
        {
            var expectedRender = ChartTestUtility.GetRenderedObjectNew().Trim().Replace(Environment.NewLine, "");

            var newBuilderRenderer = new FusionChartsCore.FusionChartBuilder(new FusionChartsCore.ChartParameters()
            {
                ChartType = FusionChartsCore.ChartType.column3d,
                Id = "myChart",
                htmlWidth = "600",
                htmlHeight = "350",
                dataFormat = FusionChartsCore.DataFormat.jsonurl,
                dataSource = "../Data/Data.json"
            });

            var newBuildRender = newBuilderRenderer.Render().Trim().Replace(Environment.NewLine, "");
            
            Assert.Equal(expectedRender.Length, newBuildRender.Length);
        }

        [Fact]
        public void TestNewReframeRenderWithAdditionalDetails()
        {
            var expectedRender = ChartTestUtility.GetRenderedObjectNew().Trim().Replace(Environment.NewLine, "");

            var newBuilderRenderer = new FusionChartsCore.FusionChartBuilder(new FusionChartsCore.ChartParameters()
            {
                ChartType = FusionChartsCore.ChartType.column3d,
                Id = "myChart",
                htmlWidth = "600",
                htmlHeight = "350",
                dataFormat = FusionChartsCore.DataFormat.jsonurl,
                dataSource = "../Data/Data.json"
            });

            newBuilderRenderer.ChartParams.additionalParameters.Add("test1", "test1val");
            newBuilderRenderer.ChartParams.additionalParameters.Add("test2", "test2val");

            var newBuildRender = newBuilderRenderer.Render().Trim().Replace(Environment.NewLine, "");

            Assert.Equal(expectedRender.Length+20+19, newBuildRender.Length);
        }
    }
}

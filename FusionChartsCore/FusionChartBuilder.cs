using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FusionChartsCore
{
    public class FusionChartBuilder
    {
        ChartParameters _innerChartParams;

        public ChartParameters ChartParams
        {
            get
            {
                return _innerChartParams;
            }
        }
            
            

        public FusionChartBuilder(ChartParameters chartParams)
        {
            _innerChartParams = chartParams;
        }

        /// <summary>
        /// Public method to generate html code for rendering chart
        /// This function assumes that you've already included the FusionCharts JavaScript class in your page
        /// </summary>
        /// <returns>JavaScript + HTML code required to embed a chart</returns>
        public string Render()
        {
            return RenderChartALL();
        }

        /// <summary>
        /// Generate html code for rendering chart
        /// This function assumes that you've already included the FusionCharts JavaScript class in your page
        /// </summary>
        /// <returns>JavaScript + HTML code required to embed a chart</returns>
        private string RenderChartALL()
        {

            string dataSource = _innerChartParams.dataSource;
            string dataFormat = _innerChartParams.dataFormat.ToString();
            string chartId = _innerChartParams.Id;
            string renderAt = _innerChartParams.renderAt;



            StringBuilder builder = new StringBuilder();
            builder.AppendFormat("<!-- Using ASP.NET FusionCharts Wrapper and JavaScript rendering --><!-- START Script Block for Chart {0} -->" + Environment.NewLine, chartId);
            // if the user has provided renderAt then assume that the HTML container is already present in the page.
            if (String.IsNullOrWhiteSpace(renderAt))
            {
                renderAt = chartId + "_div";
                // Now create the container div also.
                builder.AppendFormat("<div id='{0}' >" + Environment.NewLine, renderAt);
                builder.Append("Chart..." + Environment.NewLine);
                builder.Append("</div>" + Environment.NewLine);
            }

            string chartConfigJSON = fc_encodeJSON(true);

            //JA Change, using Json.Net returns properly formed JSON, no removal needed
            // Removes the extra trailing commas in generated JavaScript Object
            //int Place = chartConfigJSON.LastIndexOf(',');
            //chartConfigJSON = (Place >= 0) ? chartConfigJSON.Remove(Place, 1).Insert(Place, "") : chartConfigJSON;

            builder.Append("<script type=\"text/javascript\">" + Environment.NewLine);
            builder.Append("FusionCharts && FusionCharts.ready(function () {" + Environment.NewLine);
            builder.AppendFormat("if (FusionCharts(\"{0}\") ) FusionCharts(\"{0}\").dispose();" + Environment.NewLine, chartId);
            builder.AppendFormat("var chart_{0} = new FusionCharts({1}).render();" + Environment.NewLine, chartId, chartConfigJSON);
            builder.Append("});" + Environment.NewLine);
            builder.Append("</script>" + Environment.NewLine);
            builder.AppendFormat("<!-- END Script Block for Chart {0} -->" + Environment.NewLine, chartId);

            return builder.ToString();

        }


        private string fc_encodeJSON(bool enclosed)
        {
            string jsonNew;

            if (String.IsNullOrWhiteSpace(_innerChartParams.renderAt))
            {
                _innerChartParams.renderAt = _innerChartParams.Id.ToString() + "_div";

                jsonNew = Newtonsoft.Json.JsonConvert.SerializeObject(_innerChartParams,
                    new Newtonsoft.Json.JsonSerializerSettings
                    {
                        NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                        DefaultValueHandling = Newtonsoft.Json.DefaultValueHandling.Ignore,
                    });

                //__CONFIG__["renderAt"] = null;
            }
            else
            {
                jsonNew = Newtonsoft.Json.JsonConvert.SerializeObject(_innerChartParams,
                    new Newtonsoft.Json.JsonSerializerSettings
                    {
                        NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                        DefaultValueHandling = Newtonsoft.Json.DefaultValueHandling.Ignore
                    });
            }

            return jsonNew;
            //return strjson;
        }
    }
}

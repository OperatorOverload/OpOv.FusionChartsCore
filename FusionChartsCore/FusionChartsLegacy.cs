using System;
using System.Text;
using System.Linq;
using System.Collections;
//using System.Web.UI.WebControls;
//using System.Web;
using System.Collections.Generic;
using System.Collections.Specialized;
//using System.Globalization;

namespace FusionChartsCore.Legacy
{
    /// <summary>
    /// Contains methods to render FusionCharts in the Page. 
    /// </summary>
    public class LegacyChart
    {
        //StringDictionary p = null;
        private Dictionary<string,string> __CONFIG__ = null;
        private static Dictionary<string, string> __PARAMMAP__ = null;
        
        #region constructor methods
        /// <summary>
        /// Chart constructor
        /// Chart configuration parameters can be supplyed to the constructor also.
        /// </summary>
        public LegacyChart()
        {
            __INIT();
        }

        /// <summary>
        /// Chart constructor
        /// </summary>
        /// <param name="chartType">The type of chart that you intend to plot</param>
        public LegacyChart(string chartType)
        {
            __INIT();

            SetChartParameter("type", chartType);
        }

        /// <summary>
        /// Chart constructor
        /// </summary>
        /// <param name="chartType">The type of chart that you intend to plot</param>
        /// <param name="chartId">Id for the chart, using which it will be recognized in the HTML page. Each chart on the page needs to have a unique Id.</param>
        public LegacyChart(string chartType, string chartId)
        {
            __INIT();

            SetChartParameter("type", chartType);
            SetChartParameter("id", chartId);
        }

        /// <summary>
        /// Chart constructor
        /// </summary>
        /// <param name="chartType">The type of chart that you intend to plot</param>
        /// <param name="chartId">Id for the chart, using which it will be recognized in the HTML page. Each chart on the page needs to have a unique Id.</param>
        /// <param name="chartWidth">Intended width for the chart (in pixels)</param>
        public LegacyChart(string chartType, string chartId, string chartWidth)
        {
            __INIT();

            SetChartParameter("type", chartType);
            SetChartParameter("id", chartId);
            SetChartParameter("width", chartWidth);
        }

        /// <summary>
        /// Chart constructor
        /// </summary>
        /// <param name="chartType">The type of chart that you intend to plot</param>
        /// <param name="chartId">Id for the chart, using which it will be recognized in the HTML page. Each chart on the page needs to have a unique Id.</param>
        /// <param name="chartWidth">Intended width for the chart (in pixels)</param>
        /// <param name="chartHeight">Intended height for the chart (in pixels)</param>
        public LegacyChart(string chartType, string chartId, string chartWidth, string chartHeight)
        {
            __INIT();

            SetChartParameter("type", chartType);
            SetChartParameter("id", chartId);
            SetChartParameter("width", chartWidth);
            SetChartParameter("height", chartHeight);
        }

        /// <summary>
        /// Chart constructor
        /// </summary>
        /// <param name="chartType">The type of chart that you intend to plot</param>
        /// <param name="chartId">Id for the chart, using which it will be recognized in the HTML page. Each chart on the page needs to have a unique Id.</param>
        /// <param name="chartWidth">Intended width for the chart (in pixels)</param>
        /// <param name="chartHeight">Intended height for the chart (in pixels)</param>
        /// <param name="dataFormat">Data format. e.g. json, jsonurl, csv, xml, xmlurl</param>
        public LegacyChart(string chartType, string chartId, string chartWidth, string chartHeight, string dataFormat)
        {
            __INIT();

            SetChartParameter("type", chartType);
            SetChartParameter("dataFormat", dataFormat);
            SetChartParameter("id", chartId);
            SetChartParameter("width", chartWidth);
            SetChartParameter("height", chartHeight);
        }

        /// <summary>
        /// Chart constructor
        /// </summary>
        /// <param name="chartType">The type of chart that you intend to plot</param>
        /// <param name="chartId">Id for the chart, using which it will be recognized in the HTML page. Each chart on the page needs to have a unique Id.</param>
        /// <param name="chartWidth">Intended width for the chart (in pixels)</param>
        /// <param name="chartHeight">Intended height for the chart (in pixels)</param>
        /// <param name="dataFormat">Data format. e.g. json, jsonurl, csv, xml, xmlurl</param>
        /// <param name="dataSource">Data for the chart</param>
        public LegacyChart(string chartType, string chartId, string chartWidth, string chartHeight, string dataFormat, string dataSource)
        {
            __INIT();

            SetChartParameter("type", chartType);
            SetChartParameter("dataFormat", dataFormat);
            SetData(dataSource);
            SetChartParameter("id", chartId);
            SetChartParameter("width", chartWidth);
            SetChartParameter("height", chartHeight);
        }

        /// <summary>
        /// Chart constructor
        /// </summary>
        /// <param name="chartType">The type of chart that you intend to plot</param>
        /// <param name="chartId">Id for the chart, using which it will be recognized in the HTML page. Each chart on the page needs to have a unique Id.</param>
        /// <param name="chartWidth">Intended width for the chart (in pixels)</param>
        /// <param name="chartHeight">Intended height for the chart (in pixels)</param>
        /// <param name="dataFormat">Data format. e.g. json, jsonurl, csv, xml, xmlurl</param>
        /// <param name="dataSource">Data for the chart</param>
        /// <param name="bgColor">Background color of the chart container</param>
        public LegacyChart(string chartType, string chartId, string chartWidth, string chartHeight, string dataFormat, string dataSource,
            string bgColor)
        {
            __INIT();

            SetChartParameter("type", chartType);
            SetChartParameter("dataFormat", dataFormat);
            SetData(dataSource);
            SetChartParameter("id", chartId);
            SetChartParameter("width", chartWidth);
            SetChartParameter("height", chartHeight);
            SetChartParameter("containerBackgroundColor", bgColor);
        }

        /// <summary>
        /// Chart constructor
        /// </summary>
        /// <param name="chartType">The type of chart that you intend to plot</param>
        /// <param name="chartId">Id for the chart, using which it will be recognized in the HTML page. Each chart on the page needs to have a unique Id.</param>
        /// <param name="chartWidth">Intended width for the chart (in pixels)</param>
        /// <param name="chartHeight">Intended height for the chart (in pixels)</param>
        /// <param name="dataFormat">Data format. e.g. json, jsonurl, csv, xml, xmlurl</param>
        /// <param name="dataSource">Data for the chart</param>
        /// <param name="bgColor">Back-ground-color of the chart container</param>
        /// <param name="bgOpacity">Background opacity of the chart container</param>
        public LegacyChart(string chartType, string chartId, string chartWidth, string chartHeight, string dataFormat, string dataSource,
            string bgColor, string bgOpacity)
        {
            __INIT();

            SetChartParameter("type", chartType);
            SetChartParameter("dataFormat", dataFormat);
            SetData(dataSource);
            SetChartParameter("id", chartId);
            SetChartParameter("width", chartWidth);
            SetChartParameter("height", chartHeight);
            SetChartParameter("containerBackgroundColor", bgColor);
            SetChartParameter("containerBackgroundOpacity", bgOpacity);
        }
        #endregion

        #region RenderALL methods

        /// <summary>
        /// Generate html code for rendering chart
        /// This function assumes that you've already included the FusionCharts JavaScript class in your page
        /// </summary>
        /// <returns>JavaScript + HTML code required to embed a chart</returns>
        private string RenderChartALL()
        {

            string dataSource = GetChartParameter("dataSource");
            string dataFormat = GetChartParameter("dataFormat");
            string chartId = GetChartParameter("id");
            string renderAt = GetChartParameter("renderAt");



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

            // Removes the extra trailing commas in generated JavaScript Object
            int Place = chartConfigJSON.LastIndexOf(',');
            chartConfigJSON = (Place >= 0) ? chartConfigJSON.Remove(Place, 1).Insert(Place, "") : chartConfigJSON;

            builder.Append("<script type=\"text/javascript\">" + Environment.NewLine);
            builder.Append("FusionCharts && FusionCharts.ready(function () {" + Environment.NewLine);
            builder.AppendFormat("if (FusionCharts(\"{0}\") ) FusionCharts(\"{0}\").dispose();" + Environment.NewLine, chartId);
            builder.AppendFormat("var chart_{0} = new FusionCharts({1}).render();" + Environment.NewLine, chartId, chartConfigJSON);
            builder.Append("});" + Environment.NewLine);
            builder.Append("</script>" + Environment.NewLine);
            builder.AppendFormat("<!-- END Script Block for Chart {0} -->" + Environment.NewLine, chartId);

            return builder.ToString();

        }

        #endregion

        #region Public Methods
        /// <summary>
        /// Public method to clone an exiting FusionCharts instance
        /// To make the chartId unique, this function will add "_clone" as suffix in the clone chart's Id.
        /// </summary>
        //public object Clone()
        //{
        //    Chart ChartClone = new Chart();
        //    ChartClone.__CONFIG__ = (Hashtable)this.__CONFIG__.Clone();
        //    ChartClone.SetChartParameter("id", ((Hashtable)ChartClone.__CONFIG__["params"])["id"].ToString() + "_clone");

        //    return ChartClone;
        //}

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
        /// Public method to generate html code for rendering chart
        /// This function assumes that you've already included the FusionCharts JavaScript class in your page
        /// </summary>
        /// <param name="chartType">The type of chart that you intend to plot</param>
        /// <returns>JavaScript + HTML code required to embed a chart</returns>

        public string Render(string chartType)
        {
            SetChartParameter("type", chartType);

            return RenderChartALL();
        }

        /// <summary>
        /// Public method to generate html code for rendering chart
        /// This function assumes that you've already included the FusionCharts JavaScript class in your page
        /// </summary>
        /// <param name="chartType">The type of chart that you intend to plot</param>
        /// <param name="chartId">Id for the chart, using which it will be recognized in the HTML page. Each chart on the page needs to have a unique Id.</param>
        /// <returns>JavaScript + HTML code required to embed a chart</returns>

        public string Render(string chartType, string chartId)
        {
            SetChartParameter("type", chartType);
            SetChartParameter("id", chartId);

            return RenderChartALL();
        }

        /// <summary>
        /// Public method to generate html code for rendering chart
        /// This function assumes that you've already included the FusionCharts JavaScript class in your page
        /// </summary>
        /// <param name="chartType">The type of chart that you intend to plot</param>
        /// <param name="chartId">Id for the chart, using which it will be recognized in the HTML page. Each chart on the page needs to have a unique Id.</param>
        /// <param name="chartWidth">Intended width for the chart (in pixels)</param>
        /// <returns>JavaScript + HTML code required to embed a chart</returns>

        public string Render(string chartType, string chartId, string chartWidth)
        {
            SetChartParameter("type", chartType);
            SetChartParameter("id", chartId);
            SetChartParameter("width", chartWidth);

            return RenderChartALL();
        }

        /// <summary>
        /// Public method to generate html code for rendering chart
        /// This function assumes that you've already included the FusionCharts JavaScript class in your page
        /// </summary>
        /// <param name="chartType">The type of chart that you intend to plot</param>
        /// <param name="chartId">Id for the chart, using which it will be recognized in the HTML page. Each chart on the page needs to have a unique Id.</param>
        /// <param name="chartWidth">Intended width for the chart (in pixels)</param>
        /// <param name="chartHeight">Intended height for the chart (in pixels)</param>
        /// <returns>JavaScript + HTML code required to embed a chart</returns>

        public string Render(string chartType, string chartId, string chartWidth, string chartHeight)
        {
            SetChartParameter("type", chartType);
            SetChartParameter("id", chartId);
            SetChartParameter("width", chartWidth);
            SetChartParameter("height", chartHeight);

            return RenderChartALL();
        }

        /// <summary>
        /// Public method to generate html code for rendering chart
        /// This function assumes that you've already included the FusionCharts JavaScript class in your page
        /// </summary>
        /// <param name="chartType">The type of chart that you intend to plot</param>
        /// <param name="chartId">Id for the chart, using which it will be recognized in the HTML page. Each chart on the page needs to have a unique Id.</param>
        /// <param name="chartWidth">Intended width for the chart (in pixels)</param>
        /// <param name="chartHeight">Intended height for the chart (in pixels)</param>
        /// <param name="dataFormat">Data format. e.g. json, jsonurl, csv, xml, xmlurl</param>
        /// <returns>JavaScript + HTML code required to embed a chart</returns>

        public string Render(string chartType, string chartId, string chartWidth, string chartHeight, string dataFormat)
        {
            SetChartParameter("type", chartType);
            SetChartParameter("dataFormat", dataFormat);
            SetChartParameter("id", chartId);
            SetChartParameter("width", chartWidth);
            SetChartParameter("height", chartHeight);

            return RenderChartALL();
        }

        /// <summary>
        /// Public method to generate html code for rendering chart
        /// This function assumes that you've already included the FusionCharts JavaScript class in your page
        /// </summary>
        /// <param name="chartType">The type of chart that you intend to plot</param>
        /// <param name="chartId">Id for the chart, using which it will be recognized in the HTML page. Each chart on the page needs to have a unique Id.</param>
        /// <param name="chartWidth">Intended width for the chart (in pixels)</param>
        /// <param name="chartHeight">Intended height for the chart (in pixels)</param>
        /// <param name="dataFormat">Data format. e.g. json, jsonurl, csv, xml, xmlurl</param>
        /// <param name="dataSource">Data for the chart</param>
        /// <returns>JavaScript + HTML code required to embed a chart</returns>

        public string Render(string chartType, string chartId, string chartWidth, string chartHeight, string dataFormat, string dataSource)
        {
            SetChartParameter("type", chartType);
            SetChartParameter("dataFormat", dataFormat);
            SetData(dataSource);
            SetChartParameter("id", chartId);
            SetChartParameter("width", chartWidth);
            SetChartParameter("height", chartHeight);

            return RenderChartALL();
        }


        /// <summary>
        /// Public method to generate html code for rendering chart
        /// This function assumes that you've already included the FusionCharts JavaScript class in your page
        /// </summary>
        /// <param name="chartType">The type of chart that you intend to plot</param>
        /// <param name="chartId">Id for the chart, using which it will be recognized in the HTML page. Each chart on the page needs to have a unique Id.</param>
        /// <param name="chartWidth">Intended width for the chart (in pixels)</param>
        /// <param name="chartHeight">Intended height for the chart (in pixels)</param>
        /// <param name="dataFormat">Data format. e.g. json, jsonurl, csv, xml, xmlurl</param>
        /// <param name="dataSource">Data for the chart</param>
        /// <param name="bgColor">Background color of the chart container</param>
        /// <returns>JavaScript + HTML code required to embed a chart</returns>

        public string Render(string chartType, string chartId, string chartWidth, string chartHeight, string dataFormat, string dataSource,
            string bgColor)
        {
            SetChartParameter("type", chartType);
            SetChartParameter("dataFormat", dataFormat);
            SetData(dataSource);
            SetChartParameter("id", chartId);
            SetChartParameter("width", chartWidth);
            SetChartParameter("height", chartHeight);
            SetChartParameter("containerBackgroundColor", bgColor);

            return RenderChartALL();
        }


        /// <summary>
        /// Public method to generate html code for rendering chart
        /// This function assumes that you've already included the FusionCharts JavaScript class in your page
        /// </summary>
        /// <param name="chartType">The type of chart that you intend to plot</param>
        /// <param name="chartId">Id for the chart, using which it will be recognized in the HTML page. Each chart on the page needs to have a unique Id.</param>
        /// <param name="chartWidth">Intended width for the chart (in pixels)</param>
        /// <param name="chartHeight">Intended height for the chart (in pixels)</param>
        /// <param name="dataFormat">Data format. e.g. json, jsonurl, csv, xml, xmlurl</param>
        /// <param name="dataSource">Data for the chart</param>
        /// <param name="bgColor">Background color of the chart container</param>
        /// <param name="bgOpacity">Background opacity of the chart container</param>
        /// <returns>JavaScript + HTML code required to embed a chart</returns>

        public string Render(string chartType, string chartId, string chartWidth, string chartHeight, string dataFormat, string dataSource,
            string bgColor, string bgOpacity)
        {
            SetChartParameter("type", chartType);
            SetChartParameter("dataFormat", dataFormat);
            SetData(dataSource);
            SetChartParameter("id", chartId);
            SetChartParameter("width", chartWidth);
            SetChartParameter("height", chartHeight);
            SetChartParameter("containerBackgroundColor", bgColor);
            SetChartParameter("containerBackgroundOpacity", bgOpacity);

            return RenderChartALL();
        }





        /// <summary>
        /// SetChartParameter sets various configurations of a FusionCharts instance
        /// </summary>
        /// <param name="param">Name of chart parameter</param>
        /// <param name="value">Value of chart parameter</param>
        public void SetChartParameter(LegacyChartParameters param, string value)
        {

            SetChartParameter(__PARAMMAP__[param.ToString()].ToString(), value);
        }

        /// <summary>
        /// GetChartParameter returns the value of a parameter of a FusionCharts instance
        /// </summary>
        /// <param name="param">Name of chart parameter</param>
        /// <returns>String</returns>

        public string GetChartParameter(LegacyChartParameters param)
        {
            return GetChartParameter(__PARAMMAP__[param.ToString()].ToString());
        }

        /// <summary>
        /// This method to set the data for the chart
        /// </summary>
        /// <param name="dataSource">Data for the chart</param>

        public void SetData(string dataSource)
        {
            SetChartParameter("dataSource", dataSource);
        }

        /// <summary>
        /// This method to set the data for the chart
        /// </summary>
        /// <param name="dataSource">Data for the chart</param>
        /// <param name="dataFormat">Data format. e.g. json, jsonurl, csv, xml, xmlurl</param>
        public void SetData(string dataSource, DataFormat format)
        {
            SetChartParameter("dataSource", dataSource);
            SetChartParameter("dataFormat", format.ToString());
        }

        #endregion



        #region Helper Private Methods

        /// <summary>
        /// SetConfiguration sets various configurations of FusionCharts
        /// It takes configuration names as first parameter and its value a second parameter
        /// There are config groups which can contain common configuration names. All config names in all groups gets set with this value
        /// unless group is specified explicitly
        /// </summary>
        /// <param name="setting">Name of configuration</param>
        /// <param name="value">Value of configuration</param>
        private void SetChartParameter(string setting, string value)
        {
            __CONFIG__[setting] = value;
            
        }


        private void SetParamsMap()
        {
            if (__PARAMMAP__ == null)
            {
                __PARAMMAP__ = new Dictionary<string, string>();
                __PARAMMAP__["chartType"] = "type";
                __PARAMMAP__["chartId"] = "id";
                __PARAMMAP__["chartWidth"] = "width";
                __PARAMMAP__["chartHeight"] = "height";
                __PARAMMAP__["dataFormat"] = "dataFormat";
                __PARAMMAP__["dataSource"] = "dataSource";
                __PARAMMAP__["renderAt"] = "renderAt";
                __PARAMMAP__["bgColor"] = "containerBackgroundColor";
                __PARAMMAP__["bgOpacity"] = "containerBackgroundOpacity";
            }

        }

        private void __INIT()
        {
            __CONFIG__ = new Dictionary<string, string>();
            //Hashtable param = new Hashtable(StringComparer.OrdinalIgnoreCase);
            __CONFIG__["type"] = "";
            __CONFIG__["width"] = "";
            __CONFIG__["height"] = "";
            __CONFIG__["renderAt"] = "";
            __CONFIG__["dataSource"] = "";
            __CONFIG__["dataFormat"] = "";
            __CONFIG__["id"] = Guid.NewGuid().ToString().Replace("-", "_");
            
            //Commented out since it will be explicitly set if needed
            //__CONFIG__["containerBackgroundColor"] = "";
            //__CONFIG__["containerBackgroundOpacity"] = "";

            //__CONFIG__["params"] = param;

            //param = null;
            SetParamsMap();
        }



        /// <summary>
        /// Transform the meaning of boolean value in integer value
        /// </summary>
        /// <param name="value">true/false value to be transformed</param>
        /// <returns>1 if the value is true, 0 if the value is false</returns>
        private static int boolToNum(bool value)
        {
            return value ? 1 : 0;
        }


        private string GetChartParameter(string setting)
        {
            if (__CONFIG__.ContainsKey(setting))
            {
                return __CONFIG__[setting];
            }
            return null;
        }


        private string fc_encodeJSON(bool enclosed)
        {
            var limitedKeyValMap = __CONFIG__;
            //string strjson = "", Key = "", Value = "";

            //foreach (var ds in limitedKeyValMap)
            //{
            //    if (!String.IsNullOrWhiteSpace(ds.Value))//.Trim() != "")
            //    {
            //        Key = ds.Key;
            //        Value = ds.Value;
            //        // If this is not the dataSource then convert the value as JavaScript string
            //        if (Key.ToLower().Equals("datasource"))
            //        {
            //            // Remove new line char from the dataSource
            //            Value.Replace("\n\r", "");
            //            Value.Replace("\n", "");
            //            Value.Replace("\r", "");
            //            // detect if non-JSON format then wrap with quot '"'
            //            if (!(Value.StartsWith("{") && Value.EndsWith("}")))
            //            {
            //                Value = "\"" + Value + "\"";
            //            }
            //        }
            //        else
            //        {
            //            Value = "\"" + Value + "\"";
            //        }
            //        strjson = strjson + Environment.NewLine + "\"" + Key + "\" : " + Value + ", ";
            //    }
            //    else if (ds.Key.ToString().Equals("renderAt"))
            //    {
            //        strjson = strjson + Environment.NewLine + "\"renderAt\" : \"" + __CONFIG__["id"].ToString() + "_div\", ";
            //    }
            //}
            //// remove ending comma
            //if (strjson.EndsWith(",")) strjson = strjson.Remove(strjson.Length - 1);

            //if (enclosed == true)
            //{
            //    strjson = "{" + strjson + Environment.NewLine + "}";
            //}

            string jsonNew;

            if (String.IsNullOrWhiteSpace(__CONFIG__["renderAt"]))
            {
                __CONFIG__["renderAt"] = __CONFIG__["id"].ToString() + "_div";

                jsonNew = Newtonsoft.Json.JsonConvert.SerializeObject(limitedKeyValMap,
                    new Newtonsoft.Json.JsonSerializerSettings
                    {
                        NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                        DefaultValueHandling = Newtonsoft.Json.DefaultValueHandling.Ignore,
                    });

                __CONFIG__["renderAt"] = null;
            }
            else
            {
                jsonNew = Newtonsoft.Json.JsonConvert.SerializeObject(limitedKeyValMap,
                    new Newtonsoft.Json.JsonSerializerSettings
                    {
                        NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                        DefaultValueHandling = Newtonsoft.Json.DefaultValueHandling.Ignore
                    });
            }

            return jsonNew;
            //return strjson;
        }

        private Dictionary<string, string> GetConfigurationParameters()
        {
            return __CONFIG__;
        }

        #endregion

    }
}



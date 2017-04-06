using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FusionChartsCore
{
    [JsonConverter(typeof(ChartParameterJsonConverter))]
    public class ChartParameters
    {
        public ChartParameters()
        {
            additionalParameters = new Dictionary<string, string>();
            //additionalParameters.Add("test1", "test1val");
            //additionalParameters.Add("test2", "test2val");
        }

        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ChartType ChartType { get; set; }

        [JsonProperty(PropertyName = "width")]
        public string htmlWidth { get; set; }

        [JsonProperty(PropertyName = "height")]
        public string htmlHeight { get; set; }

        [JsonProperty(PropertyName = "renderAt")]
        public string renderAt { get; set; }

        [JsonProperty(PropertyName = "dataSource")]
        public string dataSource { get; set; }

        [JsonProperty(PropertyName = "dataFormat")]
        [JsonConverter(typeof(StringEnumConverter))]
        public DataFormat dataFormat { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "containerBackgroundColor")]
        public string containerBackgroundColor { get; set; }

        [JsonProperty(PropertyName = "containerBackgroundOpacity")]
        public string containerBackgroundOpacity { get; set; }

        public Dictionary<string,string> additionalParameters { get; set; }
    }
}

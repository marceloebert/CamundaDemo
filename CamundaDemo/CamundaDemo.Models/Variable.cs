using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CamundaDemo.Models
{
    public class Variable
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public object Value { get; set; }
    }
}

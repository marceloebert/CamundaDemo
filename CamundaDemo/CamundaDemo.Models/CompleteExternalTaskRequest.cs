using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CamundaDemo.Models
{
    public class CompleteExternalTaskRequest
    {
        [JsonProperty("workerId")]
        public string WorkerId { get; set; }

        [JsonProperty("variables")]
        public Dictionary<string, Variable> Variables { get; set; }
    }
}

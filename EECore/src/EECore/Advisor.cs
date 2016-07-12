using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using Microsoft.Rest;
using Microsoft.Rest.Serialization;

namespace EECore
{
    public class Advisor
    {
        WebRequests web;

        public Advisor()
        {
            web = new WebRequests();
        }

        [JsonProperty(PropertyName = "cnum")]
        public int cnum { get; set; }

        public void Sync()
        {

        }
    }
}

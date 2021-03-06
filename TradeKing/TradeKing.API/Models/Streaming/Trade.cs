﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TradeKing.API.Models.Streaming
{

    public class Trade : StreamDataItem
    {

        [JsonProperty("cvol")]
        public string Cvol { get; set; }

        [JsonProperty("last")]
        public string Last { get; set; }

        [JsonProperty("vl")]
        public string Vl { get; set; }

        [JsonProperty("vwap")]
        public string Vwap { get; set; }
    }

}

﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TradeKingAPI.Base.Responses;

namespace TradeKingAPI.Models.Responses
{

    public class QuoteResponse : BaseResponse
    {

        [JsonProperty("response")]
        public Quote.Response Response { get; set; }
    }

}
﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TradeKingAPI.Interfaces;
using TradeKingAPI.Base.Responses;
using TradeKingAPI.Models.WatchList;

namespace TradeKingAPI.Models.Responses
{

    public class WatchListResponse : BaseResponse
    {
        [JsonProperty("response")]
        public WatchList.Response Response { get; set; }
    }

}
﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TradeKing.API.Models.Transactions
{

    public class Transaction
    {

        [JsonProperty("activity")]
        public string Activity { get; set; }

        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }
        public string DateF
        {
            get { 
                DateTime d = DateTime.Parse(Date);
                return String.Format("{0}/{1}/{2}", d.Month, d.Day, d.Year);
            }
        }

        [JsonProperty("desc")]
        public string Desc { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("transaction")]
        public Transaction2 transaction { get; set; }
    }

}

﻿using Newtonsoft.Json;

namespace FinanceNewsTicker.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
   
    public class FinanceNews
    {
        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }

        [JsonProperty("data")]
        public List<NewsArticle> Data { get; set; }
    }


}

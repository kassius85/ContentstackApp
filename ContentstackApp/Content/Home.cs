using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ContentstackApp.Content
{
    public class Home
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("cards_style")]
        public CardsStyle CardsStyle { get; set; }
        [JsonPropertyName("most_requested_subtitle")]
        public string MostRequestedSubtitle { get; set; }
        [JsonPropertyName("products")]
        public List<ProductDetail> ProductDetailList { get; set; }
    }
}

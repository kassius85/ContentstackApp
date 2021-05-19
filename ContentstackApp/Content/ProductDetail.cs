using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ContentstackApp.Content
{
    public class ProductDetail
    {   
        [JsonPropertyName("uid")]
        public string Uid { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("abstract")]
        public string Abstract { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("price")]
        public decimal Price { get; set; }
        [JsonPropertyName("title_size")]
        public int TitleSize { get; set; }
        [JsonPropertyName("video_and_images")]
        public List<VideoImage> VideoImages { get; set; }
    }
}

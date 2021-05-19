using System.Text.Json.Serialization;

namespace ContentstackApp.Content
{
    public class ResponseProduct
    {
        [JsonPropertyName("entry")]
        public Product Products { get; set; }
    }
}

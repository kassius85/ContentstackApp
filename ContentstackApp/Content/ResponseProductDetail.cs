using System.Text.Json.Serialization;

namespace ContentstackApp.Content
{
    public class ResponseProductDetail
    {
        [JsonPropertyName("entry")]
        public ProductDetail Product { get; set; }
    }
}

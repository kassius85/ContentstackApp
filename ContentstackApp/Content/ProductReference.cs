using System.Text.Json.Serialization;

namespace ContentstackApp.Content
{
    public class ProductReference
    {
        [JsonPropertyName("uid")]
        public string Uid { get; set; }
        [JsonPropertyName("_content_type_uid")]
        public string ContentTypeUid { get; set; }
    }
}

using System.Text.Json.Serialization;

namespace ContentstackApp.Content
{
    public class ResponseHeader
    {
        [JsonPropertyName("entry")]
        public Header Header { get; set; }
    }
}

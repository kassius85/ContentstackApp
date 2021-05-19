using System.Text.Json.Serialization;

namespace ContentstackApp.Content
{
    public class ResponseHome
    {
        [JsonPropertyName("entry")]
        public Home Home { get; set; }
    }
}

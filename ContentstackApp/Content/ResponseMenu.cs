using System.Text.Json.Serialization;

namespace ContentstackApp.Content
{
    public class ResponseMenu
    {
        [JsonPropertyName("entry")]
        public Menu Menu { get; set; }
    }
}

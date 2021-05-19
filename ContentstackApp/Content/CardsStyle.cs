using System.Text.Json.Serialization;

namespace ContentstackApp.Content
{
    public class CardsStyle
    {
        [JsonPropertyName("background_color")]
        public string BackgroundColor { get; set; }
        [JsonPropertyName("button_color")]
        public string ButtonColor { get; set; }
        [JsonPropertyName("text_color")]
        public string TextColor { get; set; }
    }
}

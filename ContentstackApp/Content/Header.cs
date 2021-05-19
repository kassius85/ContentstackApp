using System.Text.Json.Serialization;

namespace ContentstackApp.Content
{
    public class Header
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("background_color")]
        public string BackgroundColor { get; set; }
        [JsonPropertyName("text_color")]
        public string TextColor { get; set; }
        [JsonPropertyName("text_font")]
        public string TextFont { get; set; }
        [JsonPropertyName("text_size")]
        public int TextSize { get; set; }
        [JsonPropertyName("text_style")]
        public string TextStyle { get; set; }
        [JsonPropertyName("text_weight")]
        public int TextWeight { get; set; }
    }
}

using System.Text.Json.Serialization;

namespace ContentstackApp.Content
{
    public class Menu
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("background_color")]
        public string BackgroundColor { get; set; }
        [JsonPropertyName("image")]
        public FileInfo MenuImage { get; set; }
    }
}

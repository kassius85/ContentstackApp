using System.Text.Json.Serialization;

namespace ContentstackApp.Content
{
    public class VideosContainer
    {
        [JsonPropertyName("video")]
        public FileInfo Video { get; set; }
    }
}

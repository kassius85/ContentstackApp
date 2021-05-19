using System.Text.Json.Serialization;

namespace ContentstackApp.Content
{
    public class VideoImage
    {
        [JsonPropertyName("images")]
        public ImagesContainer ImagesContainer { get; set; }
        [JsonPropertyName("videos")]
        public VideosContainer VideosContainer { get; set; }
    }
}

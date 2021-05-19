using System.Text.Json.Serialization;

namespace ContentstackApp.Content
{
    public class FileInfo
    {
        [JsonPropertyName("filename")]
        public string FileName { get; set; }
        [JsonPropertyName("url")]
        public string Url { get; set; }
        [JsonPropertyName("content_type")]
        public string ContentType { get; set; }
    }
}

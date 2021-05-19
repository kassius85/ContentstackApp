using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ContentstackApp.Content
{
    public class ImagesContainer
    {
        [JsonPropertyName("image")]
        public List<FileInfo> Images { get; set; }
    }
}

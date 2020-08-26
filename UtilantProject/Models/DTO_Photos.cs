using System;
using System.Drawing;
using System.Text.Json.Serialization;

namespace UtilantProject.Models.Photos
{
    public class DTO_Photos
    {
        [JsonPropertyName("albumId")]
        public int AlbumId { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("thumbnailUrl")]
        public string ThumbNailUrl { get; set; }
        public string AlbumTitle { get; internal set; }
    }
}

using System.ComponentModel;
using System.Text.Json.Serialization;

namespace UtilantProject.Models.Posts
{
    public class DTO_Posts
    {
        [JsonPropertyName("userId")]
        [DisplayName("User Id")]
        public int UserId { get; set; }

        [JsonPropertyName("id")]
        [DisplayName("Post Id")]
        public int Id { get; set; }

        [JsonPropertyName("title")]
        [DisplayName("Title")]
        public string Title { get; set; }

        [JsonPropertyName("body")]
        [DisplayName("Body")]
        public string Body { get; set; }
    }
}

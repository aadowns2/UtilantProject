using System.Text.Json.Serialization;

namespace UtilantProject.Models.Todos
{
    public class DTO_Todos
    {
        [JsonPropertyName("userId")]
        public int UserId { get; set; }
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("completed")]
        public bool Completed { get; set; }
    }
}

using System.Collections.Generic;
using System.ComponentModel;
using System.Text.Json.Serialization;
using UtilantProject.Models.Demographics;

namespace UtilantProject.Models.Albums
{
    public class DTO_Albums
    {
        [JsonPropertyName("userId")]
        public int UserId { get; set; }

        [JsonPropertyName("id")]
        [DisplayName("Album Id")]
        public int Id { get; set; }

        [JsonPropertyName("title")]
        [DisplayName("Album Title")]
        public string Title { get; set; }

        public List<DTO_Demographics> Demographics { get; set; }
    }
}

using System.Collections.Generic;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace UtilantProject.Models.Demographics
{
    public class DTO_Demographics
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        
        [JsonPropertyName("name")]
        public string Name { get; set; }
        
        [JsonPropertyName("username")]
        public string Username { get; set; }
        
        [JsonPropertyName("email")]
        public string Email { get; set; }
        
        public DTO_Address Address { get; set; }
        
        [JsonPropertyName("phone")]
        public string Phone { get; set; }
        
        [JsonPropertyName("website")]
        public string Website { get; set; }
        
        public DTO_Company Company { get; set; }
    }

    public class JsonRoot
    {
        public List<DTO_Demographics> Users { get; set; }
    }
}
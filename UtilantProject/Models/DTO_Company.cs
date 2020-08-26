﻿using System.Text.Json.Serialization;

namespace UtilantProject.Models.Demographics
{
    public class DTO_Company
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        
        [JsonPropertyName("catchphrase")]
        public string CatchPhrase { get; set; }
        
        [JsonPropertyName("bs")]
        public string Bs { get; set; }
    }
}

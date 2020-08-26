using System.Text.Json.Serialization;

namespace UtilantProject.Models.Demographics
{
    public class DTO_GeoLocation
    {
        [JsonPropertyName("lat")]
        public string Lat { get; set; }
        
        [JsonPropertyName("lng")]
        public string Lng { get; set; }
    }
}

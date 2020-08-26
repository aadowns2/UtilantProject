using System.Text.Json.Serialization;

namespace UtilantProject.Models.Demographics
{
    public class DTO_Address
    {
        [JsonPropertyName("street")]
        public string Street { get; set; }
        
        [JsonPropertyName("suite")]
        public string Suite { get; set; }
        
        [JsonPropertyName("city")]
        public string City { get; set; }
        
        [JsonPropertyName("zipcode")]
        public string Zipcode { get; set; }
        
        public DTO_GeoLocation Geo { get; set; }
    }
}

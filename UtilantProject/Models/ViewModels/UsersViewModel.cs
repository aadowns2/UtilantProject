using System.ComponentModel;
using System.Text.Json.Serialization;

namespace UtilantProject.Models.ViewModels
{
    public class UsersViewModel
    {
        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("Name")]
        public string Name { get; set; }

        [DisplayName("Username")]
        public string Username { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName("Street")]
        public string Street { get; set; }

        [DisplayName("Suite")]
        public string Suite { get; set; }

        [DisplayName("City")]
        public string City { get; set; }

        [DisplayName("Zip Code")]
        public string ZipCode { get; set; }

        [DisplayName("Lat")]
        public string Latitude { get; set; }

        [DisplayName("Lng")]
        public string Longitude { get; set; }

        [DisplayName("Phone")]
        public string Phone { get; set; }

        [DisplayName("Website")]
        public string Website { get; set; }

        [DisplayName("Company Name")]
        public string CompanyName { get; set; }

        [DisplayName("Company CatchPhrase")]
        public string CompanyCatchPhrase { get; set; }

        [DisplayName("Company Bs")]
        public string CompanyBs { get; set; }
    }
}

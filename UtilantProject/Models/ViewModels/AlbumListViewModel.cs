using System.ComponentModel;

namespace UtilantProject.Models.ViewModels
{
    public class AlbumListViewModel
    {
        public string ThumbNail { get; set; }

        [DisplayName("Album Title")] public string Title { get; set; }

        [DisplayName("Name")] public string Name { get; set; }

        [DisplayName("Email")] public string Email { get; set; }

        [DisplayName("Phone")] public string Phone { get; set; }

        [DisplayName("Street")] public string Street { get; set; }

        [DisplayName("City")] public string City { get; set; }

        [DisplayName("Zip Code")] public string ZipCode { get; set; }

        public int AlbumId { get; set; }
    }
}

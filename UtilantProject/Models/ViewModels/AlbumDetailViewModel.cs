using System.ComponentModel;

namespace UtilantProject.Models.ViewModels
{
    public class AlbumDetailViewModel
    {
        [DisplayName("Thumb Nail")] 
        public string Thumbnail { get; set; }

        [DisplayName("Title")]
        public string Title { get; set; }
        
        public int AlbumId { get; set; }

        public string AlbumTitle { get; set; }
    }
}
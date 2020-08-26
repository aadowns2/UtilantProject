using System.ComponentModel;
using System.Text.Json.Serialization;

namespace UtilantProject.Models.ViewModels
{
    public class PostsViewModel
    {
        [DisplayName("User Name")]
        public string UserName { get; set; }

        [DisplayName("Post Title")]
        public string Title { get; set; }

        [DisplayName("Post Body")]
        public string Body { get; set; }

        public int UserId { get; set; }
    }
}

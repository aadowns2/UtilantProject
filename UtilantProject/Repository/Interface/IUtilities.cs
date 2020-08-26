using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using UtilantProject.Models.Albums;
using UtilantProject.Models.Comments;
using UtilantProject.Models.Demographics;
using UtilantProject.Models.Photos;
using UtilantProject.Models.Posts;
using UtilantProject.Models.Todos;

namespace UtilantProject.Repository.Interface
{
    public interface IUtilities
    {
        Task<List<DTO_Albums>> ReadAlbumJson(string name);
        Task<List<DTO_Comments>> ReadCommentsJson(string name);
        Task<List<DTO_Demographics>> ReadDemographicsJson(string name);
        Task<List<DTO_Posts>> ReadPostsJson(string name);
        Task<List<DTO_Photos>> ReadPhotoJson(string name);
        Task<List<DTO_Todos>> ReadTodosJson(string name);
    }
}

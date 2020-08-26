using System.Collections.Generic;
using System.Threading.Tasks;
using UtilantProject.Models.Albums;

namespace UtilantProject.Repository.Interface
{
    public interface IAlbum
    {
        Task<List<DTO_Albums>> GetAlbums(string name);
    }
}

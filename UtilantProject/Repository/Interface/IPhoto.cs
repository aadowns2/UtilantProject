using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UtilantProject.Models.Photos;

namespace UtilantProject.Repository.Interface
{
    public interface IPhoto
    {
        Task<List<DTO_Photos>> GetPhotos(string name);
    }
}

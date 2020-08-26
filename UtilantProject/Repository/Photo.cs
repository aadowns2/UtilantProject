using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using UtilantProject.Models.Photos;
using UtilantProject.Repository.Interface;

namespace UtilantProject.Repository
{
    public class Photo : IPhoto
    {
        private IUtilities _iutilities;

        public Photo(IUtilities iUtilities)
        {
            _iutilities = iUtilities;
        }

        public async Task<List<DTO_Photos>> GetPhotos(string name)
        {
            return await _iutilities.ReadPhotoJson(name);
        }

    }
}

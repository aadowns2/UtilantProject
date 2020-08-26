using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UtilantProject.Models.Posts;
using UtilantProject.Repository.Interface;

namespace UtilantProject.Repository
{
    public class Post : IPost
    {
        private IUtilities _iutilities;

        public Post(IUtilities iutilities)
        {
            _iutilities = iutilities;
        }

        public async Task<List<DTO_Posts>> GetPosts(string name)
        {
            return await _iutilities.ReadPostsJson(name);
        }
    }
}

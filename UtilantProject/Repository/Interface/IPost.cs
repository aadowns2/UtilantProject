using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UtilantProject.Models.Photos;
using UtilantProject.Models.Posts;

namespace UtilantProject.Repository.Interface
{
    public interface IPost
    {
        Task<List<DTO_Posts>> GetPosts(string name);
    }
}

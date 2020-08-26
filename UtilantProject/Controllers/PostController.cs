using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UtilantProject.Models.Demographics;
using UtilantProject.Models.Posts;
using UtilantProject.Models.Url;
using UtilantProject.Models.ViewModels;
using UtilantProject.Repository.Interface;

namespace UtilantProject.Controllers
{
    public class PostController : Controller
    {
        private IUtilities _iutilities;
        public PostController(IUtilities iutilities)
        {
            _iutilities = iutilities;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetUserPosts(int id)
        {
            List<PostsViewModel> results = (from p in await _iutilities.ReadPostsJson(ApiUrl.posts)
                                            join d in await _iutilities.ReadDemographicsJson(ApiUrl.users) on p.UserId equals d.Id
                                            where p.UserId == id 
                                            select new PostsViewModel { 
                                                UserId = p.UserId, 
                                                UserName = d.Username, 
                                                Body = p.Body, 
                                                Title = p.Title 
                                            }).ToList();
            
            return View("UserPosts", results);
        }
    }
}

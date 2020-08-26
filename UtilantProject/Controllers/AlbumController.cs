using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using UtilantProject.Models.Albums;
using UtilantProject.Models.Photos;
using UtilantProject.Models.Url;
using UtilantProject.Models.ViewModels;
using UtilantProject.Repository.Interface;

namespace UtilantProject.Controllers
{
    public class AlbumController : Controller
    {
        private IAlbum _ialbum;
        private IDemographic _idemographics;
        private IPhoto _iphoto;

        public AlbumController(IAlbum ialbum, IDemographic idemographics, IPhoto iphoto)
        {
            _ialbum = ialbum;
            _idemographics = idemographics;
            _iphoto = iphoto;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetAlbumsList()
        {
            IEnumerable<AlbumListViewModel> results = (await _ialbum.GetAlbums(ApiUrl.albums))
                .Join(await _iphoto.GetPhotos(ApiUrl.photos), 
                    albums => albums.Id, 
                    photos => photos.AlbumId, 
                    (albums, photos) => new
                    {
                        albums, photos
                    })
                .Join(await _idemographics.GetDemographics(ApiUrl.users), 
                    list => list.albums.UserId, 
                    demo => demo.Id, 
                    (lists, demo) => new
                    {
                        lists, demo
                    })
                .GroupBy(t1 => t1.lists.photos.AlbumId)
                .Select(g => new AlbumListViewModel
                {
                    ThumbNail = g.FirstOrDefault().lists.photos.ThumbNailUrl,
                    Title = g.FirstOrDefault().lists.albums.Title,
                    Name = g.FirstOrDefault().demo.Name,
                    Email = g.FirstOrDefault().demo.Email,
                    Phone = g.FirstOrDefault().demo.Phone,
                    Street = g.FirstOrDefault().demo.Address.Street,
                    City = g.FirstOrDefault().demo.Address.City,
                    ZipCode = g.FirstOrDefault().demo.Address.Zipcode,
                    AlbumId = g.FirstOrDefault().lists.albums.Id

                });

            return View("AlbumsList", results);
        }

        public async Task<IActionResult> GetAlbumDetail(int albumid)
        {
            List<AlbumDetailViewModel> results = (from albums in await _ialbum.GetAlbums(ApiUrl.albums)
                                                  join photos in await _iphoto.GetPhotos(ApiUrl.photos)
                                                      on albums.Id equals photos.AlbumId
                                                  where photos.AlbumId == albumid
                                                  select new AlbumDetailViewModel
                                                  {
                                                      Thumbnail = photos.ThumbNailUrl,
                                                      Title = photos.Title,
                                                      AlbumId = photos.Id,
                                                      AlbumTitle = albums.Title

                                                  }).ToList();

            return View("AlbumDetail", results);
        }
    }
}

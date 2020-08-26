using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using UtilantProject.Models.Demographics;
using UtilantProject.Models.Url;
using UtilantProject.Models.ViewModels;
using UtilantProject.Repository.Interface;

namespace UtilantProject.Controllers
{
    public class DemographicController : Controller
    {
        private IUtilities _iutilities;

        public DemographicController(IUtilities iutilities)
        {
            _iutilities = iutilities;
        }

        // GET: DemographicController/Details/5
        public async Task<IActionResult> GetUserDemographics(string name)
        {
            UsersViewModel demographics =
                (from demo in await _iutilities.ReadDemographicsJson(ApiUrl.users)
                 where demo.Name == name
                 select new UsersViewModel
                 {
                     Id = demo.Id,
                     Name = demo.Name,
                     Username = demo.Username,
                     Email = demo.Email,
                     Street = demo.Address.Street,
                     Suite = demo.Address.Suite,
                     City = demo.Address.City,
                     ZipCode = demo.Address.Zipcode,
                     Latitude = demo.Address.Geo.Lat,
                     Longitude = demo.Address.Geo.Lng,
                     Phone = demo.Phone,
                     Website = demo.Website,
                     CompanyName = demo.Company.Name,
                     CompanyCatchPhrase = demo.Company.CatchPhrase,
                     CompanyBs = demo.Company.Bs

                 }).FirstOrDefault();

            return View("UserDemographics", demographics);
        }
    }
}

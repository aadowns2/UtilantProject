using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using UtilantProject.Models;
using UtilantProject.Models.Demographics;
using UtilantProject.Repository.Interface;

namespace UtilantProject.Repository
{
    public class Demographic : IDemographic
    {
        private IUtilities _iutilities;

        public Demographic(IUtilities iutilities)
        {
            _iutilities = iutilities;
        }

        public async Task<List<DTO_Demographics>> GetDemographics(string name)
        {
            return await _iutilities.ReadDemographicsJson(name);
        }
    }
}

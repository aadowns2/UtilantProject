using System.Collections.Generic;
using System.Threading.Tasks;
using UtilantProject.Models.Demographics;

namespace UtilantProject.Repository.Interface
{
    public interface IDemographic
    {
        Task<List<DTO_Demographics>> GetDemographics(string name);
    }
}

using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using UtilantProject.Models;
using UtilantProject.Models.Albums;
using UtilantProject.Repository.Interface;

namespace UtilantProject.Repository
{
    public class Album : IAlbum
    {
        private IHttpClientFactory _iclientFactory;
        private IUtilities _iutilities;

        public Album(IHttpClientFactory iclientFactory, IUtilities iutilities) 
        { 
            _iclientFactory = iclientFactory;
            _iutilities = iutilities;
        }

        public async Task<List<DTO_Albums>> GetAlbums(string name)
        {
            return await _iutilities.ReadAlbumJson(name);
        }        
    }
}

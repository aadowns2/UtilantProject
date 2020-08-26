using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using UtilantProject.Models;
using UtilantProject.Models.Albums;
using UtilantProject.Models.Comments;
using UtilantProject.Models.Demographics;
using UtilantProject.Models.Photos;
using UtilantProject.Models.Posts;
using UtilantProject.Models.Todos;
using UtilantProject.Models.Url;
using UtilantProject.Repository.Interface;

namespace UtilantProject.Repository
{
    public class Utilities : IUtilities
    {
        private IHttpClientFactory _clientfactory;
        private string jsonRes = string.Empty;
        private string requestUri = ApiUrl.clientname;
        private HttpResponseMessage _resp;

        public Utilities(IHttpClientFactory clientfactory) => _clientfactory = clientfactory;

        public async Task<List<DTO_Albums>> ReadAlbumJson(string name)
        {
            GetHttpClient(name);
            if (!_resp.IsSuccessStatusCode) return null;
            jsonRes = await _resp.Content.ReadAsStringAsync();
            List<DTO_Albums> album = JsonConvert.DeserializeObject<List<DTO_Albums>>(jsonRes);
            return album;
        }

        public async Task<List<DTO_Comments>> ReadCommentsJson(string name)
        {
            GetHttpClient(name);
            if (!_resp.IsSuccessStatusCode) return null;
            jsonRes = await _resp.Content.ReadAsStringAsync();
            List<DTO_Comments> comments = JsonConvert.DeserializeObject<List<DTO_Comments>>(jsonRes);
            return comments;
        }

        public async Task<List<DTO_Posts>> ReadPostsJson(string name)
        {
            GetHttpClient(name);
            if (!_resp.IsSuccessStatusCode) return null;
            jsonRes = await _resp.Content.ReadAsStringAsync();
            List<DTO_Posts> posts = JsonConvert.DeserializeObject<List<DTO_Posts>>(jsonRes);
            return posts;
        }

        public async Task<List<DTO_Photos>> ReadPhotoJson(string name)
        {
            GetHttpClient(name);
            if (!_resp.IsSuccessStatusCode) return null;
            jsonRes = await _resp.Content.ReadAsStringAsync();
            List<DTO_Photos> photos = JsonConvert.DeserializeObject<List<DTO_Photos>>(jsonRes);
            return photos;

        }

        public async Task<List<DTO_Todos>> ReadTodosJson(string name)
        {
            GetHttpClient(name);
            if (_resp.IsSuccessStatusCode) return null;
            jsonRes = await _resp.Content.ReadAsStringAsync();
            List<DTO_Todos> todos = JsonConvert.DeserializeObject<List<DTO_Todos>>(jsonRes);
            return todos;
        }

        public async Task<List<DTO_Demographics>> ReadDemographicsJson(string name)
        {
            GetHttpClient(name);
            if (!_resp.IsSuccessStatusCode) return null;
            jsonRes = await _resp.Content.ReadAsStringAsync();
            List<DTO_Demographics> demographics = JsonConvert.DeserializeObject<List<DTO_Demographics>>(jsonRes);
            return demographics;
        }

        private HttpResponseMessage GetHttpClient(string name)
        { 
            HttpClient client = _clientfactory.CreateClient(requestUri);
            _resp = client.GetAsync(name).Result;
            return _resp;
        }
    }
}

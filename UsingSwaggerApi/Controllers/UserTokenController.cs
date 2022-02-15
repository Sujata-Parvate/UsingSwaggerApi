using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using UsingSwaggerApi.Model;

namespace UsingSwaggerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserTokenController : ControllerBase
    {

        [HttpPost]
        public async Task<ActionResult<string>> GetToken(UserModel token)
        {
            string data = JsonConvert.SerializeObject(token);
            using (var client = new HttpClient())
            {
                var url = new Uri("https://servicew.wheebox.com/WheeboxRestService_blob/getToken");
                StringContent httpConent = new StringContent(data, System.Text.Encoding.UTF8);
                var response = await client.PostAsync(url, httpConent);
                string json;
                using (var content = response.Content)
                {
                    json = await content.ReadAsStringAsync();
                }
                return json;
            }
        }

        //public async Task<Token> GetToken(Token token)
        //{

        //    string apiUrl = "https://servicew.wheebox.com/WheeboxRestService_blob/getToken";
        //    var client = new HttpClient();
        //    HttpResponseMessage response = await client.GetAsync(apiUrl).Result;

        //    token = JsonConvert.DeserializeObject<List<Token>>(response.Content.ReadAsStringAsync().Result)

        //    //response.EnsureSuccessStatusCode();

        //    // return URI of the created resource.
        //    return response;
        //}


    }
}

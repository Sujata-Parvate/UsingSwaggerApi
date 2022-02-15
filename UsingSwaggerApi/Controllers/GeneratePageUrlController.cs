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
    public class GeneratePageUrlController : ControllerBase
    {

        //[HttpPost]
        //public async Task<ActionResult<string>> GeneratePageURL(PageUrlModel pageurl)
        //{
        //    string data = JsonConvert.SerializeObject(pageurl);
        //    using (var client = new HttpClient())
        //    {
        //        var url = new Uri("https://servicew.wheebox.com/WheeboxRestService_blob/generatepageURL");
        //        StringContent httpConent = new StringContent(data, System.Text.Encoding.UTF8);
        //        var response = await client.PostAsync(url, httpConent);
        //        string json;
        //        using (var content = response.Content)
        //        {
        //            json = await content.ReadAsStringAsync();
        //        }
        //        return json;
        //    }
        //}

    }
}

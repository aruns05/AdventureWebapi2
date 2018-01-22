using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using System.Text;
using Newtonsoft.Json;
using AdventureWebapi.Models;

namespace AdventureWebapi.Controllers
{
    public class BaseAPIController : ApiController
    {
        protected readonly AdventureworksEntities db = new AdventureworksEntities();

        protected HttpResponseMessage ToJson(dynamic obj)
        {
            var response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent(JsonConvert.SerializeObject(obj),  Encoding.UTF8, "application/json");
            return response;
        }
    }
}

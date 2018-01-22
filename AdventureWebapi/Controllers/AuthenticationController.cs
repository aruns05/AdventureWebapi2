using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using AdventureWebapi.Models;

namespace AdventureWebapi.Controllers
{
    public class AuthenticationController : BaseAPIController
    {
        //private AdventureworksEntities db = new AdventureworksEntities();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="UserId"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        public IHttpActionResult Login(string UserId, string Password)
        {
            var u = db.Usercredentials.Where(c => c.UserId == UserId && c.Password == Password);
            if (u == null)
            {
                return NotFound();
            }

            return Ok(u);
           
        }

        [HttpGet]
        public HttpResponseMessage Get()
        {
            return ToJson(db.Usercredentials.AsEnumerable());
        }

        [HttpGet]
        public HttpResponseMessage Get(int? ID)
        {
            var temp= ToJson(db.Usercredentials.Where(c => c.Id == ID));
            return temp;
        }
    }
}

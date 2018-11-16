using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestApi.Controllers.Custom;

namespace RestApi.Controllers.User
{
    [Route("api/User")]
    [ApiController]
    public class UserController : ApiBaseController
    {
        [HttpGet]
        public string GetUserProfile(string userId)
        {
            return string.Empty;
        }
    }
}
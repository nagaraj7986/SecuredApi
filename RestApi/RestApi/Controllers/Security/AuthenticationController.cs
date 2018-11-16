using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestApi.Controllers.Custom;

namespace RestApi.Controllers.Security
{
    [Route("api/Authentication")]
    [ApiController]
    public class AuthenticationController : ApiBaseController
    {
        // Authentication & Authorization - Securing the API.

        //private AuthenticationService m_authenticationService = new AuthenticationService();

        [HttpPost]
        [Route("Login")]
        public string Login()
        {
            return string.Empty;
        }

        [HttpPost]
        [Route("Logout")]
        public bool Logout()
        {
            return true;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestApi.Controllers.Custom;

namespace RestApi.Controllers.Security
{
    [Route("api/Authorization")]
    [ApiController]
    public class AuthorizationController : ApiBaseController
    {
        //private AuthorizationService m_authService = new AuthorizationService();

        [HttpGet]
        [Route("")]
       // [AuthorizeAny]
        public void GetAuthorization()
        {
            //AuthorizationDto auth;
            //try
            //{
            //    GetLocaleFromHttpHeader();

            //    auth = m_authService.GetAuthorization();

            //    if (auth == null)
            //    {
            //        throw GetNotFoundError("No authorizations found");
            //    }

            //}
            //catch (Exception e)
            //{
            //    throw GetInternalServerError(e);
            //}
            //return auth;
        }
    }
}
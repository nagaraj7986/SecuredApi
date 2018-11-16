using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApi.Controllers.Custom
{
    public class OutputCacheAttribute : ActionFilterAttribute
    {
        //private string _cachekey;

        //private static readonly ObjectCache WebApiCache = MemoryCache.Default;

        ///// <summary>
        ///// Enable Cache only for Anonymous Users
        ///// </summary>
        //public bool AnonymousOnly { get; set; }

        ///// <summary>
        ///// How long response should be cached on the server side (in Seconds)
        ///// </summary>
        //public int ServerCacheExpiryTime { get; set; }

        ///// <summary>
        ///// Set Cache Header - How long response should be cached on the Client side (in Seconds)
        ///// </summary>
        //public int ClientCacheExpiryTime { get; set; }

        ///// <summary>
        ///// Cache is Shareable between Proxies
        ///// </summary>
        //public bool IsPublic { get; set; }

        //protected virtual bool IsCachingAllowed(HttpActionContext actionContext, bool anonymousOnly)
        //{
        //    if (anonymousOnly)
        //    {
        //        if (Thread.CurrentPrincipal.Identity.IsAuthenticated)
        //        {
        //            return false;
        //        }
        //    }
        //    return actionContext.Request.Method == HttpMethod.Get;
        //}

        //public override void OnActionExecuting(HttpActionContext actionContext)
        //{
        //    if (actionContext == null)
        //    {
        //        throw new ArgumentNullException("actionContext");
        //    }
        //    if (!IsCachingAllowed(actionContext, AnonymousOnly))
        //    {
        //        return;
        //    }
        //    _cachekey = string.Join(":", new string[] { actionContext.Request.RequestUri.AbsoluteUri, actionContext.Request.Headers.Accept.FirstOrDefault().ToString() });
        //    if (WebApiCache.Contains(_cachekey))
        //    {
        //        var val = (string)WebApiCache.Get(_cachekey);
        //        if (val != null)
        //        {
        //            actionContext.Response = actionContext.Request.CreateResponse();
        //            actionContext.Response.Content = new StringContent(val);
        //            var contenttype = (MediaTypeHeaderValue)WebApiCache.Get(_cachekey + ":response-ct");
        //            if (contenttype == null)
        //            {
        //                contenttype = new MediaTypeHeaderValue(_cachekey.Split(':')[1]);
        //            }
        //            actionContext.Response.Content.Headers.ContentType = contenttype;
        //            ApplyCacheHeaders(actionContext.Response);
        //            return;
        //        }
        //    }
        //}

        //public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        //{
        //    if (actionExecutedContext != null && actionExecutedContext.Response != null && actionExecutedContext.Response.StatusCode == HttpStatusCode.OK)
        //    {
        //        if (!(WebApiCache.Contains(_cachekey)))
        //        {
        //            var body = actionExecutedContext.Response.Content.ReadAsStringAsync().Result;
        //            WebApiCache.Add(_cachekey, body, DateTime.Now.AddSeconds(ServerCacheExpiryTime));
        //            WebApiCache.Add(_cachekey + ":response-ct", actionExecutedContext.Response.Content.Headers.ContentType, DateTime.Now.AddSeconds(ServerCacheExpiryTime));
        //            ApplyCacheHeaders(actionExecutedContext.ActionContext.Response);
        //        }
        //    }
        //}

        //private bool IsCacheable(HttpActionContext actnContxt)
        //{
        //    if (ServerCacheExpiryTime > 0 || ClientCacheExpiryTime > 0 && actnContxt.Request.Method == HttpMethod.Get)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        throw new InvalidOperationException("Invalid arguments passed");
        //    }
        //}

        //private void ApplyCacheHeaders(HttpResponseMessage response)
        //{
        //    if (ClientCacheExpiryTime > 0)
        //    {
        //        var cachecontrol = new CacheControlHeaderValue
        //        {
        //            MaxAge = TimeSpan.FromSeconds(ClientCacheExpiryTime),
        //            MustRevalidate = true,
        //            Public = IsPublic,
        //            Private = !IsPublic
        //        };
        //        response.Headers.CacheControl = cachecontrol;
        //    }
        //}
    }
}

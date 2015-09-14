using System;
using System.Web.Http;
using Umbraco.Web.Cache;
using Umbraco.Web.Mvc;
using Umbraco.Web.WebApi;

namespace SEOCheckerCacheRefresher
{
    [PluginController("SeoCheckerCacheRefresher")]
    public class SeoCheckerCacheController : UmbracoAuthorizedApiController
    {
        [HttpGet]
        public bool RefreshAll()
        {
            //this is just a test, this should be executed when the thing happens that should trigger the event
            DistributedCache.Instance.RefreshAll(Guid.Parse(SeoCheckerCacheRefresher.SeoCheckerCacheRefresherId), true);
            return true;
        }
    }
}

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
            //Trigger the SeoCheckerCacheRefresher, ideally this would come from the save event in SEO Checker
            DistributedCache.Instance.RefreshAll(Guid.Parse(SeoCheckerCacheRefresher.SeoCheckerCacheRefresherId), true);
            return true;
        }
    }
}

﻿using Umbraco.Core;
using Umbraco.Core.Cache;
using Umbraco.Core.Logging;

namespace SEOCheckerCacheRefresher
{
    public class SeoCheckerCacheEvents : ApplicationEventHandler
    {
        protected override void ApplicationStarted(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
            CacheRefresherBase<SeoCheckerCacheRefresher>.CacheUpdated += this.CacheCustomEvents_CacheUpdated;
        }

        private void CacheCustomEvents_CacheUpdated(SeoCheckerCacheRefresher sender, CacheRefresherEventArgs e)
        {
            // clear SEO checker cache, this will executed on all servers
            SEOChecker.Core.Helpers.Caching.ClearCache(true);
            LogHelper.Info<SeoCheckerCacheEvents>("SEO Checker cache cleared by ICacheRefresher Event");
        }
    }
}

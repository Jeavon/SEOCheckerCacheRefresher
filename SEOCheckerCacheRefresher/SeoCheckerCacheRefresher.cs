using System;
using Umbraco.Core.Cache;

namespace SEOCheckerCacheRefresher
{
    public class SeoCheckerCacheRefresher : JsonCacheRefresherBase<SeoCheckerCacheRefresher>
    {
        public static string SeoCheckerCacheRefresherId => "01A5CD45-2262-4DF5-A3DE-C4E4C4BA5C41";

        protected override SeoCheckerCacheRefresher Instance => this;

        public override Guid UniqueIdentifier => new Guid(SeoCheckerCacheRefresherId);

        public override string Name => "Clears SEO Checker cache";
    }
}

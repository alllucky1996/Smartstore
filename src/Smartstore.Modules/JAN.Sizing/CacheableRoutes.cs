using System.Collections.Generic;
using Smartstore.Core.OutputCache;

namespace JAN.Sizing
{
    internal sealed class CacheableRoutes : ICacheableRouteProvider
    {
        public int Order => 0;

        public IEnumerable<string> GetCacheableRoutes()
        {
            return new string[]
            {
                "vc:JAN.Sizing/DomainTutorial"
            };
        }
    }
}

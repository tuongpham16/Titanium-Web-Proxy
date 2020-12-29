using System;
using DnsClient;

namespace Titanium.Web.Proxy
{
    public static class LookupService
    {
        public static LookupClient LookupClient { get; set; }

        static LookupService()
        {
            if (LookupClient == null)
            {
                LookupClient = new LookupClient(new LookupClientOptions()
                {
                    UseCache = true,
                    MaximumCacheTimeout = new TimeSpan(0, 10, 0)
                });
            }
        }

    }
}


namespace Infrastructure.Cache
{
    using System;
    using System.Runtime.Caching;

    public class SimpleMemoryCache : ICacheProvider
    {
        private static readonly MemoryCache MemoryCache = MemoryCache.Default;
        private readonly CacheItemPolicy policy;

        public SimpleMemoryCache(int? slidingExpirationSeconds = 1800)
        {
            this.policy = new CacheItemPolicy();
            var expirationSeconds = slidingExpirationSeconds.HasValue ? slidingExpirationSeconds.Value : 1800;
            this.policy.SlidingExpiration = TimeSpan.FromSeconds(expirationSeconds);
        }

        public void Add(string key, object value)
        {
            MemoryCache.Add(key, value, this.policy);
        }

        public T Get<T>(string key) where T : class
        {
            return (T)MemoryCache.Get(key);
        }

        public void Remove(string key)
        {
            MemoryCache.Remove(key);
        }
    }
}
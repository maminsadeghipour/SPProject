using System;
using System.Text.Json;
using App.Domain.Core.CacheAgg.Contracts;
using Microsoft.Extensions.Caching.Distributed;

namespace App.Infrastructure.RedisCacheService.Redis
{
	public class RedisCacheService : IRedisCacheService
	{
        private readonly IDistributedCache _distributedCache;

        public RedisCacheService(IDistributedCache distributedCache)
        {
            _distributedCache = distributedCache;
        }

        public async Task<T> Get<T>(string key, CancellationToken cancellationToken)
        {
            string? value = await _distributedCache.GetStringAsync(key ,cancellationToken);


            if (value != null)
            {
                return JsonSerializer.Deserialize<T>(value);
            }

            return default;
        }

        public async Task Set<T>(string key, T value, int expTimeInHour, CancellationToken cancellationToken)
        {
            var cacheOptions = new DistributedCacheEntryOptions
            {
                AbsoluteExpiration = DateTimeOffset.Now.AddHours(expTimeInHour),                
            };
            await _distributedCache.SetStringAsync(key, JsonSerializer.Serialize(value), cacheOptions, cancellationToken);
        }

        public async Task SetSliding<T>(string key, T value, int expirationTime, CancellationToken cancellationToken)
        {
            var cacheOptions = new DistributedCacheEntryOptions
            {
                SlidingExpiration = TimeSpan.FromSeconds(expirationTime)
            };
            await _distributedCache.SetStringAsync(key, JsonSerializer.Serialize(value), cacheOptions,cancellationToken);
        }


    }
}


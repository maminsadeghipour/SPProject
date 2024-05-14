using System;
namespace App.Domain.Core.CacheAgg.Contracts
{
	public interface IRedisCacheService
	{
		Task Set<T>(string key, T value, int expTimeInHour, CancellationToken cancellationToken);
		Task<T> Get<T>(string key, CancellationToken cancellationToken);
		Task SetSliding<T>(string key, T value, int expirationTime,CancellationToken cancellationToken);

    }
}


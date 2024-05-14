using System;
namespace App.Domain.Core.EnumAgg.Contracts
{
	public interface IEnumService
	{
		IEnumerable<T> GetValues<T>();
	}
}


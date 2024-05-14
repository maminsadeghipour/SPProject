using System;
using App.Domain.Core.EnumAgg.Contracts;

namespace App.Domain.Service.EnumAgg
{
	public class EnumService : IEnumService
	{
		public EnumService()
		{
		}

        public IEnumerable<T> GetValues<T>()                    
           => Enum.GetValues(typeof(T)).Cast<T>();            
        
    
    }
}


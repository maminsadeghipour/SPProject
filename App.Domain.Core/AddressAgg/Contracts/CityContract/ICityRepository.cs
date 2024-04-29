using System;
using App.Domain.Core.AddressAgg.Entity;

namespace App.Domain.Core.AddressAgg.Contracts.CityContract
{
	public interface ICityRepository
	{
        void Add(City city);
        List<City> GetAll();
        City GetById(int id);        
        void DeleteById(int id);
    }
}


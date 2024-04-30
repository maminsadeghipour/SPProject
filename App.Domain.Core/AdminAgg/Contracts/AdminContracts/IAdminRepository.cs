using System;
using App.Domain.Core.AddressAgg.Entity;
using App.Domain.Core.AdminAgg.Entity;

namespace App.Domain.Core.AdminAgg.Contracts.AdminContracts
{
	public interface IAdminRepository
	{
        void Add(Admin admin);
        List<Admin> GetAll();
        Admin GetById(int id);
        void Update(Admin admin);
        void DeleteById(int id);
    }
}


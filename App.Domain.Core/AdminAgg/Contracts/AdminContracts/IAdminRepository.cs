using System;
using App.Domain.Core.AddressAgg.Entity;
using App.Domain.Core.AdminAgg.Entity;

namespace App.Domain.Core.AdminAgg.Contracts.AdminContracts
{
	public interface IAdminRepository
	{
        Task Add(Admin admin, CancellationToken cancellationToken);
        Task<List<Admin>> GetAll(CancellationToken cancellationToken);
        Task<Admin> GetById(int id, CancellationToken cancellationToken);
        Task Update(Admin admin, CancellationToken cancellationToken);
        Task DeleteById(int id, CancellationToken cancellationToken);
    }
}


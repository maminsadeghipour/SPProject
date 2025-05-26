using System;
using App.Domain.Core.RequestAgg.Entity;
using Microsoft.AspNetCore.Http;

namespace App.Domain.Core.RequestAgg.Contracts.RequestPictureContracts
{
	public interface IRequestPictureService
	{
		Task<List<RequestPicture>> AddPicturesToDisk(List<IFormFile> pictures);
	}
}


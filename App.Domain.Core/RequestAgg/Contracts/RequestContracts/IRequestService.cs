﻿using System;
namespace App.Domain.Core.RequestAgg.Contracts.RequestContracts
{
	public interface IRequestService
	{

        Task<int> Count(CancellationToken cancellationToken);
    }
}


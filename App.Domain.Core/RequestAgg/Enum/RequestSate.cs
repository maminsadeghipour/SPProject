using System;
namespace App.Domain.Core.RequestAgg.Enum
{
	public enum RequestSate
	{
		Added,
		WaitingForBids,
		WaitingForAcceptABidByCustomer,
		WaitingToExpertServeToCostumer,
		WaitingForCustomerFeedback,
		Finished,
		DeniedByAdmin,
		BannedByAdmin
  	}

}


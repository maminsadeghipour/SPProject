using System;
namespace App.Domain.Core.RequestAgg.Enum
{
	public enum RequestSate
	{
		Added = 1,
		WaitingForBids,
		WaitingForAcceptABidByCustomer,
		WaitingToExpertServeToCostumer,
		WaitingForCustomerFeedback,
		Finished,
		DeniedByAdmin,
		BannedByAdmin
  	}

}


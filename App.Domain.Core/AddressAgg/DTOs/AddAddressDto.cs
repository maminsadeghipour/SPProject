using System;
using App.Domain.Core.AddressAgg.Entity;
using App.Domain.Core.CustomerAgg.Entity;

namespace App.Domain.Core.AddressAgg.DTOs
{
	public class AddAddressDto
	{        
        public string Title { get; set; }
        public string Street { get; set; }        
        public int CityId { get; set; }
    }
}


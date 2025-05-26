using System;
using App.Domain.Core.AddressAgg.Entity;
using App.Domain.Core.RequestAgg.Entity;

namespace App.Domain.Core.CustomerAgg.DTOs
{
	public class ProfileCustomerDto
	{
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Username { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime RegisteredAt { get; set; }

        public int NumberOfRequests { get; set; }
        public List<Address> Addresses { get; set; }


    }
}


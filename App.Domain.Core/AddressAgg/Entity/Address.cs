using System;
using System.Diagnostics.CodeAnalysis;
using App.Domain.Core.CustomerAgg.Entity;

namespace App.Domain.Core.AddressAgg.Entity
{
	public class Address
	{
		public Address()
		{
		}

		public int Id { get; set; }
		public string Title { get; set; }	 
		public string Street { get; set; }


		// One To Many
		public int CityId { get; set; }
		public City City { get; set; }

        public Customer Customer { get; set; }
        public int CustomerId { get; set; }

        // Deleveloping Properties
        public DateTime CreatedAt { get; set; }
        [AllowNull]
        public DateTime? LastUpdatedAt { get; set; }

		public bool IsDeleted { get; set; }

    }
}


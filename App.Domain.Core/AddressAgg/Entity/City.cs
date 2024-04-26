using System;
namespace App.Domain.Core.AddressAgg.Entity
{
	public class City
	{
		public City()
		{
		}

		public int Id { get; set; }
		public string Title { get; set; }

		public List<Address> Addresses { get; set; }
	}
}


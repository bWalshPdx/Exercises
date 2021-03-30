using System;

namespace VideoStore
{
	using System.Collections;

	public class Customer
	{
		public readonly string Name;
		public readonly IList Rentals = new ArrayList();
		
		public Customer(string name)
		{
			Name = name;
		}

		public void AddRental(Rental rental) 
		{
			Rentals.Add(rental);
		}
	}
}

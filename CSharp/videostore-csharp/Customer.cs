using System;

namespace VideoStore
{
	using System.Collections;

	public class Customer
	{
		public string name;
		public IList rentals = new ArrayList();
		
		public Customer(string name)
		{
			this.name = name;
		}

		

		public void AddRental(Rental rental) 
		{
			rentals.Add(rental);
		}
	}
}

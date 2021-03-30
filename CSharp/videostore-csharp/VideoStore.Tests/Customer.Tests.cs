using System;
using Xunit;

namespace VideoStore.Tests
{
    public class Tests
    {
        Customer _customer;
        PointOfSale _pointOfSale;

        public Tests() 
        {
            _customer = new Customer("Fred");
            _pointOfSale = new PointOfSale();
        }

        [Fact]
        public void SingleNewReleaseStatement()
        {
            _customer.AddRental (new Rental (new Movie ("The Cell", Movie.NEW_RELEASE), 3));		
            Assert.Equal ("Rental Record for Fred\n\tThe Cell\t9\nYou owed 9\nYou earned 2 frequent renter points\n", _pointOfSale.GetStatement(_customer));			
        }

        [Fact]
        public void DualNewReleaseStatement () 
        {
            _customer.AddRental (new Rental (new Movie ("The Cell", Movie.NEW_RELEASE), 3));
            _customer.AddRental (new Rental (new Movie ("The Tigger Movie", Movie.NEW_RELEASE), 3));		
            Assert.Equal ("Rental Record for Fred\n\tThe Cell\t9\n\tThe Tigger Movie\t9\nYou owed 18\nYou earned 4 frequent renter points\n", _pointOfSale.GetStatement(_customer));
        }

        [Fact]
        public void SingleChildrensStatement () 
        {
            _customer.AddRental (new Rental (new Movie ("The Tigger Movie", Movie.CHILDRENS), 3));
            Assert.Equal ("Rental Record for Fred\n\tThe Tigger Movie\t1.5\nYou owed 1.5\nYou earned 1 frequent renter points\n", _pointOfSale.GetStatement(_customer));
        }
	
        [Fact]
        public void MultipleRegularStatement () 
        {
            _customer.AddRental (new Rental (new Movie ("Plan 9 from Outer Space", Movie.REGULAR), 1));
            _customer.AddRental (new Rental (new Movie ("8 1/2", Movie.REGULAR), 2));
            _customer.AddRental (new Rental (new Movie ("Eraserhead", Movie.REGULAR), 3));
		
            Assert.Equal ("Rental Record for Fred\n\tPlan 9 from Outer Space\t2\n\t8 1/2\t2\n\tEraserhead\t3.5\nYou owed 7.5\nYou earned 3 frequent renter points\n", _pointOfSale.GetStatement(_customer));
        }
    }
}
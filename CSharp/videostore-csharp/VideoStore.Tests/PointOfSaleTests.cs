using Xunit;

namespace VideoStore.Tests
{
    public class PointOfSaleTests
    {
        PointOfSale _pointOfSale;
        
        [Fact]
        public void notNull()
        {
            _pointOfSale = new PointOfSale();
        }
    }
}
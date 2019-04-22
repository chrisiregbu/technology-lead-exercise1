using System;
using Xunit;
using TheRetailStoreDiscounts.ClassLib;

namespace TheRetailStoreDiscounts.Tests
{
    public class StoreEmployeeTests
    {     
        private StoreEmployee _storeEmployee;

        [Fact]
        public void Should_Get_Thirty_Percent_Discount()
        {    
            _storeEmployee = new StoreEmployee(100.00);
        }
    
        [Fact]
        public double ReturnTrueGivenNetAmountPayable95()
        {           
            var netPayableAmount = new StoreEmployee(100.00).Discount();
            return netPayableAmount;
        }
    }
}

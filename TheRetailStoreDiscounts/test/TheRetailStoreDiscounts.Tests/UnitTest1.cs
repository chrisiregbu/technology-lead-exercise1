using System;
using Xunit;
using TheRetailStoreDiscounts.ClassLib;

namespace TheRetailStoreDiscounts.Tests
{
    public class StoreEmployeeTests
    {     
        private readonly StoreEmployee _storeEmployee;

        [Fact]
        public void Should_Get_Thirty_Percent_Discount()
        {    
            _storeEmployee = new StoreEmployee();
        }
    
        [Fact]
        public void ReturnNetAmountPayable()
        {           
            double netPayableAmount = _storeEmployee.Should_Get_Thirty_Percent_Discount().Discount();
            //Assert.True(netPayableAmount, EqualTo(.3));
        }
    }
}

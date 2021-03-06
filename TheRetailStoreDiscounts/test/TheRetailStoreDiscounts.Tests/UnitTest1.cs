using System;
using Xunit;
using TheRetailStoreDiscounts.ClassLib;
using System.Collections.Generic;

namespace TheRetailStoreDiscounts.Tests
{
    public class StoreEmployeeTests
    {     

        [Fact]
        public void StoreEmployee_NoPercentage_Discount_OnGroceris()
        {  
            /*
             * Create a Bill object with a line items
             * Ideally, a Bill object should be created from a list of line items 
             * (the LineItem class is shown on the UML class but never used) 
             * I have hard-coded it to get ahead a bit as I was running out of time
             * due to various environment setup issues throughout this exercise unfortunately.
             */
            var bill = new Bill(1, 25, "Groceries");
            
            var storeEmployee = new StoreEmployee(1);
            var netPayableAmount = storeEmployee.getNetAmountPayable(bill);

            Assert.Equal(25, netPayableAmount);
        }

        [Fact]
        public void StoreEmployee_Gets_FiveDollar_ForEveryHundred_DollarBill()
        {  
            // Quickly create Bill object with a line items and pass it to
            // User object
            var bill = new Bill(1, 990, "Laptop");
            
            var storeEmployee = new StoreEmployee(1);
            var netPayableAmount = storeEmployee.getNetAmountPayable(bill);

            Assert.Equal(945, netPayableAmount);
        }
        

        [Fact]  
         public void StoreEmployee_Gets_ThirtyPercent_Discount()
         {  
            // Quickly create Bill object with a line items and pass it to
            // User object
            var bill = new Bill(1, 75, "shoes");       
            var storeEmployee = new StoreEmployee(1);
            var netPayableAmount = storeEmployee.getNetAmountPayable(bill);

            Assert.Equal(52.5, netPayableAmount);
         }       
    }

    public class StoreAffiliateTests
    {     

        [Fact]
        public void StoreAffiliate_NoPercentage_Discount_OnGroceris()
        {  
           // Quickly create Bill object with a line items and pass it to
            // User object
            var bill = new Bill(1, 65, "Groceries");
            
            var storeAffiliate = new StoreAffiliate(1);
            var netPayableAmount = storeAffiliate.getNetAmountPayable(bill);

            Assert.Equal(65, netPayableAmount);
        }

        [Fact]
        public void StoreAffiliate_Gets_FiveDollar_ForEveryHundred_DollarBill()
        {  
            // Quickly create Bill object with a line items and pass it to
            // User object
            var bill = new Bill(1, 99, "Trainers");
            
            var storeAffiliate = new StoreAffiliate(1);
            var netPayableAmount = storeAffiliate.getNetAmountPayable(bill);

            Assert.Equal(89.1, netPayableAmount);
        }

        [Fact]  
         public void StoreAffiliate_Gets_TenPercent_Discount()
         {  
            // Quickly create Bill object with a line items and pass it to
            // User object
            var bill = new Bill(1, 75, "shoes");  

            var storeAffiliate = new StoreAffiliate(1);
            var netPayableAmount = storeAffiliate.getNetAmountPayable(bill);

            Assert.Equal(67.5, netPayableAmount);
         }
        
    }

    public class StoreCustomerTests
    {     

        [Fact]
        public void StoreCustomer_NoPercentage_Discount_OnGroceris()
        {  
            // Quickly create Bill object with a line items
            var bill = new Bill(1, 65, "Groceries");
            
            var storeCustomer = new StoreCustomer(1, 8);
            var netPayableAmount = storeCustomer.getNetAmountPayable(bill);

            Assert.Equal(65, netPayableAmount);
        }

        [Fact]
        public void StoreCustomer_Gets_FiveDollar_ForEveryHundred_DollarBill()
        {  
            // Quickly create Bill object with a line items
            var bill = new Bill(1, 1600, "Laptop");
            
            var storeCustomer = new StoreCustomer(1, 4);
            var netPayableAmount = storeCustomer.getNetAmountPayable(bill);

            Assert.Equal(1520, netPayableAmount);
        }

        [Fact]  
         public void StoreCustomer_Gets_FivePercentDiscount_IfOverTwoYears()
         {  
            // Quickly create Bill object with a line items
            var bill = new Bill(1, 75, "shoes");       
            var storeCustomer = new StoreCustomer(1, 3);
            var netPayableAmount = storeCustomer.getNetAmountPayable(bill);

            Assert.Equal(71.25, netPayableAmount);
         }

         [Fact]  
         public void StoreCustomer_DoesNotGetDiscount_IfTwoYears()
         {  
            // Quickly create Bill object with a line items
            var bill = new Bill(1, 75, "shoes");       
            var storeCustomer = new StoreCustomer(1, 2);
            var netPayableAmount = storeCustomer.getNetAmountPayable(bill);

            Assert.Equal(75, netPayableAmount);
         }

         [Fact]  
         public void StoreCustomer_DoesNotGetDiscount_IfLessTwoYears()
         {  
            // Quickly create Bill object with a line items
            var bill = new Bill(1, 75, "shoes");       
            var storeCustomer = new StoreCustomer(1, 1);
            var netPayableAmount = storeCustomer.getNetAmountPayable(bill);

            Assert.Equal(75, netPayableAmount);
         }
        
    }
}


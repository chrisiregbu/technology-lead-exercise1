using System;

namespace TheRetailStoreDiscounts.ClassLib
{
    public class StoreCustomer : User
    {
        /// <summary>
        /// The class Customer models the concept of a user whos is a customer of the retail website
        /// </summary>//
        private int customerNumber, numberOfYears;

        public StoreCustomer(int customerNumber, int numberOfYears)
        {
            this.customerNumber = customerNumber;
            this.numberOfYears = numberOfYears;
        }
        public override double getNetAmountPayable(Bill bill)
        {        
            double amount = bill.getAmount();
            double netAmountPayable;

            if(bill.getItem().Equals("Groceries") || numberOfYears <= 2) 
            {
                netAmountPayable = amount;
            }
            else
            {
                netAmountPayable = (amount >= 100) ? (amount - (hundredDollarDiscountRate * Math.Truncate(amount/100)))
                    : amount - (amount * .05);
            }

            return netAmountPayable;
        }
    }
}
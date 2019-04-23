using System;

namespace TheRetailStoreDiscounts.ClassLib
{
     /// <summary>
    /// The class StoreEmployee models the concept of a user employed by the retail website
    /// </summary>//
    public class StoreEmployee : User
    {
        private int employeeNumber;

        public StoreEmployee(int employeeNumber)
        {
            this.employeeNumber = employeeNumber;
            this.discountPercentage = 0.3;
        }

        // Store employee gets a 30% discount on non-grocery items
        public override double getNetAmountPayable(Bill bill) {

            double netAmountPayable;
            double amount = bill.getAmount();
            string item = bill.getItem();

            if (!bill.getItem().Equals("Groceries"))
            { 
                netAmountPayable = (amount >= 100) ? (amount - (hundredDollarDiscountRate * Math.Truncate(amount / 100)))
                    : (amount - (amount * discountPercentage));
            }
            else
            {
                netAmountPayable = amount;

            }

            return  netAmountPayable;
        }
    }
}
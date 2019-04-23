using System;

namespace TheRetailStoreDiscounts.ClassLib
{
    public class StoreAffiliate : User
    {
        int affliationNumber;

        /// <summary>
        /// The class StoreAffiliate models the concept of a user who is an affiliate of the retail website
        /// </summary>// 
        public StoreAffiliate(int affliationNumber)
        {
            this.affliationNumber = affliationNumber;
            discountPercentage = .1;   
        }

        public override double getNetAmountPayable(Bill bill)
        {
            double amount = bill.getAmount();
            string item = bill.getItem();
            double netAmountPayable = 0.0;

            if(item.Equals("Groceries")) 
            { 
                netAmountPayable = amount;
            }
            else
            {
                netAmountPayable = (amount >= 100) ? (amount - (hundredDollarDiscountRate * Math.Truncate(amount/100)))
                    : (amount - (amount * discountPercentage));
            }

            return netAmountPayable;
        }
    }
}
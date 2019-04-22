using System;

namespace TheRetailStoreDiscounts.ClassLib
{
    /// <summary>
    /// The  class User models the concept of a retail website user:
    /// the abstract method Discount computes the discount on items bought
    /// </summary>//     
    public abstract class User {

        protected double billAmount, discountRate = 5.0;
        protected double discountPercent;

        protected double getNetAmountPayable()
        {
            if(billAmount != 0 && billAmount > 100)
            {
                return (billAmount - (discountRate * Math.Round(billAmount/100)));
            }
            else
            {
                return (billAmount - (billAmount * discountPercent));
            }
        }
        public abstract double Discount();
    }
}

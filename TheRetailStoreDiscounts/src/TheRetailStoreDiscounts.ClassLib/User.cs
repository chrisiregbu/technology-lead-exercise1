using System;

namespace TheRetailStoreDiscounts.ClassLib
{
    /// <summary>
    /// The  class User models the concept of a retail website user:
    /// the abstract method Discount computes the discount on items bought
    /// </summary>//     
    public abstract class User {
        protected string name = "";
        protected double discountPercentage = 0;
        protected double hundredDollarDiscountRate = 5;

        public abstract double getNetAmountPayable(Bill bill);
    }
}

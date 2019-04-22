namespace TheRetailStoreDiscounts.ClassLib
{
    public class StoreCustomer : User
    {
        /// <summary>
        /// The class Customer models the concept of a user whos is a customer of the retail website
        /// </summary>//
        private int yearsAsCustomer;
        public StoreCustomer(int yearsAsCustomer, double billAmount)
        {
            this.yearsAsCustomer = yearsAsCustomer;
            this.billAmount = billAmount;
        }
        public override double Discount()
        {          
           //return (yearsAsCustomer > 2) ? (billAmount - (billAmount * discountPercent)) : this.billAmount;
           return (yearsAsCustomer > 2) ? this.getNetAmountPayable() : this.billAmount;
        }
    }
}
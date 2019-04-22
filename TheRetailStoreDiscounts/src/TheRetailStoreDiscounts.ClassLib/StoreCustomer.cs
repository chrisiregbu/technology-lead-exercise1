namespace TheRetailStoreDiscounts.ClassLib
{
    public class StoreCustomer : User
    {
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
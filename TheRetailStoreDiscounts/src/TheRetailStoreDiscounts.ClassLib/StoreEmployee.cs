namespace TheRetailStoreDiscounts.ClassLib
{
     /// <summary>
    /// The class StoreEmployee models the concept of a user employed by the retail website
    /// </summary>//
    public class StoreEmployee : User
    {
        public StoreEmployee(double billAmount)
        {
            this.discountPercent = 0.3;
            this.billAmount = billAmount;
        }
        public override double Discount() {
            //return  (billAmount - (billAmount * discountPercent));
            return this.getNetAmountPayable();
        }
    }
}
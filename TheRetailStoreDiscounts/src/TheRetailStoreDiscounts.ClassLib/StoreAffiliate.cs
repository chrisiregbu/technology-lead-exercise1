namespace TheRetailStoreDiscounts.ClassLib
{
    public class StoreAffiliate : User
    {
        /// <summary>
        /// The class StoreAffiliate models the concept of a user who is an affiliate of the retail website
        /// </summary>// 
        public StoreAffiliate(double billAmount)
        {
            this.discountPercent = 0.1;
            this.billAmount = billAmount;
        }

        public override double Discount()
        {
            //return  (billAmount - (billAmount * discountPercent));
            return this.getNetAmountPayable();
        }
    }
}
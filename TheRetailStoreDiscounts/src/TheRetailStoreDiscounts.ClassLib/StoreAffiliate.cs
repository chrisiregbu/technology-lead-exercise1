namespace TheRetailStoreDiscounts.ClassLib
{
    public class StoreAffiliate : User
    {
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
//using System.Runtime.InteropServices.WindowsRuntime;
namespace TheRetailStoreDiscounts.ClassLib
{
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
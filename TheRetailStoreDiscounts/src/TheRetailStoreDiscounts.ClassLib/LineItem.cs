using System.Collections.Specialized;
namespace TheRetailStoreDiscounts.ClassLib
{
    public class LineItem
    {
        /// <summary>
        /// The class LineItem models the concept of an items on a bill that are sold to a user by the retail website user
        /// </summary>//     

        int itemCode;
        string description;
        double unitPrice;

         public LineItem(int itemCode, string description, double unitPrice)
         {
             this.itemCode = itemCode;
             this.description = description;
             this.unitPrice = unitPrice;
         }
    }
}
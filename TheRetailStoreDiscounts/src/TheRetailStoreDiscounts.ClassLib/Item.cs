namespace TheRetailStoreDiscounts.ClassLib
{
    public class Item
    {
        /// <summary>
        /// The class Item models the concept of an item sold by the retail website user
        /// </summary>//     

        int code, quantity;
        string description, type;
        double price;

         public Item(int code, string description, string type, int quantity, double price)
         {
             this.code = code;
             this.quantity = quantity;
             this.description = description;
             this.type = type;
             this.price = price;
         }
    }
}
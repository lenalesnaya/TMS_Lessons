using System.Globalization;

namespace Lessons.Lesson9Tasks.Store
{
    ///<summary>
    ///Base abstract class for all types of goods (product, kit, etc.) in the store (implements: IPrintable).
    ///</summary>
    internal abstract class UnitOfGoods : IPrintable
    {
        public string Name { get; set; }
        public decimal WholesalePrice { get; protected set; }
        public decimal RetailPrice { get; protected set; }
        public DateTime ManufactureDate { get; set; }
        public DateTime ExpirationDate { get; protected set; }

        ///<summary>
        ///(virtual) Prints information about specific product to the console.
        ///</summary>
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Product name: {Name}");
            Console.WriteLine($"Wholesale price: {WholesalePrice.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"))}");
            Console.WriteLine($"Retail price: {RetailPrice.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"))}");
            Console.WriteLine($"Manufacture date: {ManufactureDate:g}");
            Console.WriteLine($"Expiration date: {ExpirationDate:g}");
            if (!IsNotExpired())
            {
                Console.WriteLine("Is expired!");
            }
            Console.WriteLine("-----------------");
        }

        ///<summary>
        ///Checks if specific product not expired.
        ///</summary>
        ///<returns>
        ///Returns the boolean result of the check.
        ///</returns>
        public bool IsNotExpired()
        {
            return ExpirationDate > DateTime.Now;
        }
    }
}
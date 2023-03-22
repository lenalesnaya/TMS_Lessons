using System.Globalization;

namespace Lessons.Lesson9Tasks.Store
{
    ///<summary>
    ///Represents the entity "consignment" (implements: IPrintable).
    ///</summary>
    internal class Consignment : IPrintable
    {
        public string Number { get; set; }
        public DateTime DeliveryDate { get; set; }
        public UnitOfGoods UnitOfGoods { get; set; }
        public long Quantity { get; set; }
        public decimal Price { get; private set; }

        public Consignment(string number, DateTime deliveryDate, UnitOfGoods unitOfGoods, long quantity)
        {
            Number = number;
            DeliveryDate = deliveryDate;
            UnitOfGoods = unitOfGoods;
            Quantity = quantity;

            Price = unitOfGoods.WholesalePrice * quantity;
        }

        ///<summary>
        ///(virtual) Prints information about specific сonsignment to the console.
        ///</summary>
        public virtual void PrintInfo()
        {
            Console.WriteLine($"\nConsignment number: {Number}");
            Console.WriteLine($"Delivery date: {DeliveryDate:g}");
            UnitOfGoods.PrintInfo();
            Console.WriteLine($"Quantity: {Quantity}");
            Console.WriteLine($"Consignment price: {Price.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"))}");
        }
    }
}
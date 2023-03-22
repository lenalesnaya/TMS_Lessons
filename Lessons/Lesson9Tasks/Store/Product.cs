namespace Lessons.Lesson9Tasks.Store
{
    ///<summary>
    ///Represents the entity "product", base class for specific kinds of products (base: UnitOfGoods).
    ///</summary>
    internal class Product : UnitOfGoods
    {
        public Product(string name, decimal wholesalePrice, DateTime manufactureDate, DateTime expirationDate)
        {
            Name = name;
            WholesalePrice = wholesalePrice;
            ManufactureDate = manufactureDate;
            ExpirationDate = expirationDate;

            RetailPrice = wholesalePrice * 1.30m;
        }

        ///<summary>
        ///Serves to initialize protected setter of property UnitOfGoods.WholesalePrice and protected setter of property UnitOfGoods.RetailPrice from outside the class.
        ///</summary>
        public void SetWholesalePrice(decimal wholesalePrice)
        {
            WholesalePrice = wholesalePrice;
            RetailPrice = wholesalePrice * 1.30m;
        }

        ///<summary>
        ///Serves to change value of protected setter of property UnitOfGoods.ExpirationDate from outside the class.
        ///</summary>
        public void ChangeExpirationDate(DateTime expirationDate)
        {
            ExpirationDate = expirationDate;
        }
    }
}
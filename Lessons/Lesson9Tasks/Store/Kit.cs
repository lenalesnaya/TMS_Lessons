namespace Lessons.Lesson9Tasks.Store
{
    ///<summary>
    ///Represents the entity "kit" (base: UnitOfGoods).
    ///</summary>
    internal class Kit : UnitOfGoods
    {
        public List<UnitOfGoods>? Goods { get; set; }

        public Kit(string name, List<UnitOfGoods> goods, DateTime manufactureDate)
        {
            Name = name;
            Goods = goods;
            SetWholesalePrice();
            SetRetailPrice();
            ManufactureDate = manufactureDate;
            SetExpirationDate();
        }

        ///<summary>
        ///Overrides UnitOfGoods.PrintInfo(). Uses base implementation and adds some more information to print to the console.
        ///</summary>
        public override void PrintInfo()
        {
            if (Goods is not null)
            {
                base.PrintInfo();

                Console.WriteLine("Composition:");
                for (int i = 0; i < Goods.Count; i++)
                {
                    Console.WriteLine($"{i + 1}.");
                    Goods[i].PrintInfo();
                }
            }
        }

        ///<summary>
        ///Serves to change value of protected setter of property UnitOfGoods.RetailPrice from outside the class.
        ///</summary>
        ///<param name="retailPrice">A value for RetailPrice.</param>
        public void ChangeRetailPrice(decimal retailPrice)
        {
            RetailPrice = retailPrice;
        }

        ///<summary>
        ///Serves to initialize protected setter of property UnitOfGoods.WholesalePrice.
        ///</summary>
        private void SetWholesalePrice()
        {
            WholesalePrice = Goods?.Sum(g => g.WholesalePrice) ?? default;
        }

        ///<summary>
        ///Serves to initialize protected setter of property UnitOfGoods.RetailPrice.
        ///</summary>
        private void SetRetailPrice()
        {
            RetailPrice = Goods?.Sum(g => g.RetailPrice) ?? default;
        }

        ///<summary>
        ///Serves to initialize protected setter of property UnitOfGoods.ExpirationDate.
        ///</summary>
        private void SetExpirationDate()
        {
            ExpirationDate = Goods?.Min(p => p.ExpirationDate) ?? default;
        }
    }
}
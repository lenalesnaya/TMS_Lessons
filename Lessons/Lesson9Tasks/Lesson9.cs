using Lessons.Lesson9Tasks.Store;
using System.Collections;
using System.Globalization;
using System.Text;

namespace Lessons.Lesson9Tasks
{
    internal class Lesson9
    {
        public static void Task0_CatchArgumentOutOfRangeException()
        {
            Console.WriteLine("\nTask 0.1.\n");

            try
            {
                ArrayList list = new();
                object s = list[18];
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public static void Task0_PrintDictionary()
        {
            Console.WriteLine("\nTask 0.2.\n");

            var englishNorwegianDictionary = new Dictionary<string, string>()
            {
                { "milk", "melk" },
                { "bread", "brød" },
                { "sour cream", "rømme" },
                { "meat", "kjøtt" },
                { "butter", "smør" },
                { "buckwheat", "bokhvete" },
                { "cucumber", "agurk" },
                { "fish", "fisk" },
                { "sugar", "sukker" },
                { "carrot", "gulrot" }
            };

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("\n{0,-30}{1,-30}", "English", "Norwegian\n");
            DictionaryHelper.PrintDictionary(englishNorwegianDictionary);
        }

        public static void Task1_UseStore()
        {
            Console.WriteLine("\nTask 1.\n");

            PrintCollectionInfo(ProductsDb.Products);

            var expiredGoods = ProductsDb.Products.FindAll(p => p.IsNotExpired() == false);
            if (expiredGoods.Count > 0)
            {
                Console.WriteLine("\nExpired goods:\n");
                PrintCollectionInfo(expiredGoods);
            }

            ProductsDb.Products.Add(new Product(
                "Coffee \"Pauling\"", 15.70m, new DateTime(2022, 12, 11, 12, 15, 00), new DateTime(2023, 12, 19, 12, 15, 00)));
            (ProductsDb.Products.Find(p => p.Name == "Chocolate kit \"For lovers\"") as Kit)?.ChangeRetailPrice(5);
            ProductsDb.Products.RemoveAt(ProductsDb.Products.Count - 1);

            Console.WriteLine();
            PrintCollectionInfo(ProductsDb.Products);

            var cheapGoods = GetCheapGoods(ProductsDb.Products);
            if (cheapGoods.Count > 0)
            {
                Console.WriteLine("\nCheap goods:\n");
                PrintCollectionInfo(cheapGoods);
            }

            Console.WriteLine(
                $"The cheapest product costs {cheapGoods.Min(p => p.RetailPrice).ToString("C2", CultureInfo.CreateSpecificCulture("en-US"))}");
            ProductsDb.Products.Clear();

            PrintCollectionInfo(ProductsDb.Consignments);

            var consignmentsDictionary = CreateDictionary(ProductsDb.Consignments);
            if (consignmentsDictionary.Count > 0)
            {
                Console.WriteLine("\nConsignments:\n");
                Console.WriteLine("{0,-30}{1,-30}", "Name", "Quantity\n");
                DictionaryHelper.PrintDictionary(consignmentsDictionary);

                Console.WriteLine("\nProducts names:\n");
                DictionaryHelper.PrintDictionaryKeys(consignmentsDictionary);

                Console.WriteLine("\nQuantities:\n");
                DictionaryHelper.PrintDictionaryValues(consignmentsDictionary);
            }

            var keyValuePairList = consignmentsDictionary.ToList();
            var newDictionary = keyValuePairList.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
        }

        ///<summary>
        ///Calls method PrintInfo() on IPrintable objects contained in the collection.
        ///</summary>
        ///<param name="collection">Represents the collection of IPrintable objects.</param>
        private static void PrintCollectionInfo<TElement>(List<TElement> collection)
            where TElement : IPrintable
        {
            foreach (var element in collection)
            {
                element.PrintInfo();
            }
        }

        ///<summary>
        ///Gets a new collection of goods from the original collection, selecting elements by property RetailPrice, which is less than 1.0m.
        ///</summary>
        ///<param name="goods">Represents the oroginal collection of goods.</param>
        ///<returns>
        ///Returns the new collection of goods.
        ///</returns>
        private static List<UnitOfGoods> GetCheapGoods(List<UnitOfGoods> goods)
        {
            var cheapGoods = new List<UnitOfGoods>();
            foreach (var product in goods)
            {
                if (product.RetailPrice <= 1.0m)
                {
                    cheapGoods.Add(product);
                }
            }

            return cheapGoods;
        }

        ///<summary>
        ///Creates new Dictionary from properties Name and Quantity of Consignment objects, contained in the collection.
        ///</summary>
        ///<param name="consignments">Represents the oroginal collection of consignments.</param>
        ///<returns>
        ///Returns the new dictionary of "name-quantity" pairs.
        ///</returns>
        private static Dictionary<string, long> CreateDictionary(List<Consignment> consignments)
        {
            var dictionary = new Dictionary<string, long>();
            foreach (var consignment in consignments)
            {
                dictionary.Add(consignment.UnitOfGoods.Name, consignment.Quantity);
            }

            return dictionary;
        }
    }
}
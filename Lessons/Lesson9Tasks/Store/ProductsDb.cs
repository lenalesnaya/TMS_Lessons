namespace Lessons.Lesson9Tasks.Store
{
    internal struct ProductsDb
    {
        public static List<UnitOfGoods> ProductsForKit = new()
        {
            new Product("Chocolate \"Milka\"", 1.90m, new DateTime(2023, 02, 10, 09, 15, 00), new DateTime(2023, 10, 19, 09, 15, 00)),
            new Product("Chocolate \"AlpenGold\"", 1.40m, new DateTime(2023, 03, 11, 10, 00, 00), new DateTime(2023, 11, 11, 10, 00, 00)),
        };

        public static List<UnitOfGoods> Products { get; set; } = new()
        {
            new Product("Chew gum \"Huba-buba\"", 0.50m, new DateTime(2023, 02, 01, 15, 00, 00), new DateTime(2024, 02, 20, 15, 00, 00)),
            new Product("Milk \"Prostokvashino\"", 0.70m, new DateTime(2023, 03, 01, 06, 10, 00), new DateTime(2023, 03, 20, 06, 10, 00)),
            new Product("Cheese \"President\"", 4.30m, new DateTime(2023, 03, 19, 15, 10, 00), new DateTime(2023, 07, 01, 15, 10, 00)),
            new Kit("Chocolate kit \"For lovers\"", ProductsForKit, new DateTime(2023, 03, 20, 10, 00, 00))
        };

        public static List<Consignment> Consignments { get; set; } = new()
        {
            new Consignment("MM12800N6",
                new DateTime(2023, 03, 21, 17, 00, 00),
                new Product("Tea \"Greenfield\"", 3.70m, new DateTime(2023, 01, 02, 11, 00, 00), new DateTime(2025, 01, 02, 11, 00, 00)),
                100),
            new Consignment("MM45802N9",
                new DateTime(2023, 03, 21, 19, 00, 00),
                new Product("Candy \"Chupa-chups\"", 1.70m, new DateTime(2023, 03, 01, 12, 00, 00), new DateTime(2024, 12, 01, 12, 00, 00)),
                250),
            new Consignment("MB00492V0",
                new DateTime(2023, 03, 22, 10, 30, 00),
                new Product("Long loaf \"Berezinsky\"", 0.90m, new DateTime(2023, 03, 22, 11, 30, 00), new DateTime(2023, 03, 25, 11, 30, 00)),
                30),
            new Consignment("MB1542V0K",
                new DateTime(2023, 03, 22, 15, 02, 00),
                new Product("Drink \"Coca-cola\"", 2.70m, new DateTime(2022, 11, 01, 11, 02, 00), new DateTime(2023, 11, 01, 11, 02, 00)),
                30),
            new Consignment("NU154NR20",
                new DateTime(2023, 03, 22, 15, 33, 00),
                new Product("Mineral water \"Darida\"", 1.50m, new DateTime(2023, 01, 20, 05, 30, 00), new DateTime(2024, 01, 20, 05, 30, 00)),
                150)
        };
    }
}
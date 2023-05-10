namespace Lessons.Lesson11Tasks
{
    internal class HousingPrices
    {
        private readonly Random random = new();
        private readonly List<decimal> prices = new();

        public event Action<List<decimal>> AddPrices;

        public HousingPrices(Action<List<decimal>> addPrices)
        {
            AddPrices = addPrices;

            for (int i = 0; i < 10; i++)
            {
                prices.Add(random.NextInt64(0, 5000000));
            }

            AddPrices?.Invoke(prices);
        }

        public void Add(decimal price)
        {
            prices.Add(price);
            AddPrices?.Invoke(prices);
        }
    }
}
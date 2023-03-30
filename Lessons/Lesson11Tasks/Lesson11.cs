using System.Globalization;

namespace Lessons.Lesson11Tasks
{
    internal class Lesson11
    {
        public static void Task1_UseHousingPrices()
        {
            Console.WriteLine("\nTask 1.\n");

            var monitor = new PriceMonitor(ShowPrice);
            var ad = new Advertisement();
            var taxService = new TaxService();
            var president = new President();

            monitor.stringArgsEventManager.Subscribe(ad, EventType.AverageHousingPriceFell);
            monitor.stringArgsEventManager.Subscribe(taxService, EventType.AverageHousingPriceIncreased);
            monitor.priceMonitorArgsEventManager.Subscribe(taxService, EventType.AverageHousingChanged);
            monitor.priceMonitorArgsEventManager.Subscribe(president, EventType.AverageHousingChanged);

            var housingPrices = new HousingPrices(monitor.CalculateAveragePrice);
            monitor.ShowAveragePrice();
            housingPrices.Add(400000m);
            monitor.ShowAveragePrice();
        }

        private static void ShowPrice(decimal price)
        {
            Console.WriteLine($"\nAverage housing price: {price.ToString("C2", CultureInfo.CreateSpecificCulture("by-BY"))}");
        }
    }
}
using System.Globalization;

namespace Lessons.Lesson11Tasks
{
    internal class PriceMonitor
    {
        public EventManager<string> stringArgsEventManager { get; }
        public EventManager<PriceMonitor> priceMonitorArgsEventManager { get; }
        public Action<decimal> ShowMessage { get; set; }
        public decimal AveragePrice { get; private set; }

        public PriceMonitor(Action<decimal> showMessage)
        {
            ShowMessage = showMessage;
            stringArgsEventManager = new EventManager<string>();
            priceMonitorArgsEventManager = new EventManager<PriceMonitor>();
        }

        public void ShowAveragePrice()
        {
            ShowMessage?.Invoke(AveragePrice);
        }

        public void CalculateAveragePrice(List<decimal> prices)
        {
            AveragePrice = prices.Average(x => x);
            priceMonitorArgsEventManager.Notify(EventType.AverageHousingChanged, this);

            if (AveragePrice < 1000000000)
            {
                stringArgsEventManager.Notify(EventType.AverageHousingPriceFell,
                    $"Housing price fell to {AveragePrice.ToString("C2", CultureInfo.CreateSpecificCulture("by-BY"))}!");
            }

            if (AveragePrice > 5000000000)
            {
                stringArgsEventManager.Notify(EventType.AverageHousingPriceIncreased,
                    $"Housing price increased to {AveragePrice.ToString("C2", CultureInfo.CreateSpecificCulture("by-BY"))}!");
            }
        }
    }
}
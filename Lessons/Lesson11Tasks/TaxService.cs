using System.Globalization;

namespace Lessons.Lesson11Tasks
{
    internal class TaxService : IListener<string>, IListener<PriceMonitor>
    {
        public void Update(string arg)
        {
            Console.WriteLine("\nWe count taxes and we have to figure it out!");
            Console.WriteLine();
        }

        public void Update(PriceMonitor arg)
        {
            Console.WriteLine(
                $"\nWe count taxes and we`ve known that the average house price is now " +
                $"{arg.AveragePrice.ToString("C2", CultureInfo.CreateSpecificCulture("by-BY"))}");
        }
    }
}
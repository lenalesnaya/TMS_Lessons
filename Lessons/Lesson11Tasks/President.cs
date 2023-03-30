namespace Lessons.Lesson11Tasks
{
    internal class President : IListener<PriceMonitor>
    {
        public void Update(PriceMonitor arg)
        {
            Console.WriteLine("\nI'm the president, do what i say!");

            if (arg.AveragePrice < 1000000)
            {
                Console.WriteLine($"Urgently raise prices!!!!!!!");
            }
            else
            {
                Console.WriteLine($"Urgently reduce prices!!!!!!");
            }
        }
    }
}
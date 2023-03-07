namespace Lessons
{
    internal class Phone
    {
        public long number;
        public string model;
        public double weight;


        public Phone() { }

        public Phone(long number, string model)
        {
            this.number = number;
            this.model = model;
            weight = 0.0;
        }

        public Phone(long number, string model, double weight) : this(number, model)
        {
            this.weight = weight;
        }


        public void ReceiveCall(string callerName)
        {
            Console.WriteLine($"\n{callerName} is calling {number:+#####-###-##-##}!");
        }

        public void ReceiveCall(string callerName, long callerNumber)
        {
            Console.WriteLine($"\n{callerName} with the number {callerNumber:+#####-###-##-##} is calling {number:+#####-###-##-##}!");
        }

        public long GetNumber()
        {
            return number;
        }

        public static void SendMessage(long number, params long[] otherNumbers)
        {
            Console.WriteLine("\nMessage will be sent to the following numbers:");
            Console.WriteLine($"{number:+#####-###-##-##}");

            if (otherNumbers != null)
            {
                foreach (var otherNumber in otherNumbers)
                {
                    Console.WriteLine($"{otherNumber:+#####-###-##-##}");
                }
            }
        }
    }
}
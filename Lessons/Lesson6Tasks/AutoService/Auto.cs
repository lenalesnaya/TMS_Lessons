namespace Lessons.Lesson6Tasks.AutoService
{
    ///<summary>
    ///Base abstract class for all kinds of vehicle in auto service.
    ///</summary>
    internal abstract class Auto
    {
        public string Model { get; set; }
        public string Number { get; set; }
        public double MaxSpeed { get; set; }
        public abstract double LoadCapacity { get; protected set; }

        public Auto(string model, string number, double maxSpeed)
        {
            Model = model;
            Number = number;
            MaxSpeed = maxSpeed;
        }

        ///<summary>
        ///(virtual) Prints information about specific vehicle to the console.
        ///</summary>
        public virtual void ShowInfo()
        {
            Console.WriteLine($"\nType: {this}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Number: {Number}");
            Console.WriteLine($"Max speed: {MaxSpeed} km/h");
            if (LoadCapacity > 0)
            Console.WriteLine($"Load capacity: {LoadCapacity} t");
        }

        ///<summary>
        ///Overrides Object.ToString().Gets the name of the type in string format.
        ///</summary>
        ///<returns>
        ///Returns the name of the type.
        ///</returns>
        public override string ToString()
        {
            return GetType().Name.ToLower();
        }
    }
}
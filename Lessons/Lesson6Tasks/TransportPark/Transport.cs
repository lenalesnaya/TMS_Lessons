namespace Lessons.Lesson6Tasks.TransportPark
{
    ///<summary>
    ///Base abstract class for all kinds of transport in public transport park.
    ///</summary>
    internal abstract class Transport
    {
        public string Number { get; set; }
        public TypeOfTrip TypeOfTrip { get; set; }
        public string PointOfDeparture { get; set; }
        public DateTime DepartureTime { get; set; }
        public string Destination { get; set; }
        public ushort NumberOfSeats { get; set; }
        public abstract TypeOfMovement? MovementType { get; }
        public abstract TypeOfEngine? EngineType { get; }

        public Transport(string number, TypeOfTrip typeOfTrip, string pointOfDeparture,DateTime departureTime, string destination, ushort numberOfSeats)
        {
            Number = number;
            TypeOfTrip = typeOfTrip;
            PointOfDeparture = pointOfDeparture;
            DepartureTime = departureTime;
            Destination = destination;
            NumberOfSeats = numberOfSeats;
        }

        ///<summary>
        ///(virtual) Prints information about specific transport to the console.
        ///</summary>
        public virtual void ShowInfo()
        {
            Console.WriteLine($"\nThe {this} #{Number}");
            Console.WriteLine($"Type of trip: {GetTypeOfTripString()}");
            Console.WriteLine($"Point of departure: {PointOfDeparture}");
            Console.WriteLine($"Time of departure: {DepartureTime:g}");
            Console.WriteLine($"Destination: {Destination}");
            Console.WriteLine($"Number of seats: {NumberOfSeats}");
        }

        ///<summary>
        ///(virtual) Returns a set of values, describing the transport type.
        ///</summary>
        ///<param name="transportName">Using the "out" modifier returns the name of the transport.</param>
        ///<param name="movementType">Using the "out" modifier returns the movement type of the transport.</param>
        ///<param name="engineType">Using the "out" modifier returns the engine type of the transport.</param>
        public virtual void GetTransportType(
            out string transportName, out TypeOfMovement? movementType, out TypeOfEngine? engineType)
        {
            transportName = ToString();
            movementType = MovementType;
            engineType = EngineType;
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

        ///<summary>
        ///Overrides Object.Equals(object? obj). Compares two objects of base type "Transport" by type and property "Number".
        ///</summary>
        ///<param name="obj">Object to compare.</param>
        ///<returns>
        ///Returns the boolean result of the comparison.
        ///</returns>
        public override sealed bool Equals(object? obj)
        {
            if (obj?.GetType() == GetType())
                return (obj as Transport)?.Number == Number;
            return false;
        }

        ///<summary>
        ///(virtual) Gets the string of the type of trip property.
        ///</summary>
        ///<returns>
        ///Returns type of trip string.
        ///</returns>
        protected virtual string GetTypeOfTripString()
        {
            return TypeOfTrip switch
            {
                TypeOfTrip.Urban => "urban",
                TypeOfTrip.Suburban => "suburban",
                TypeOfTrip.Intercity => "intercity",
                TypeOfTrip.International => "international",
                _ => "indefined",
            };
        }
    }
}
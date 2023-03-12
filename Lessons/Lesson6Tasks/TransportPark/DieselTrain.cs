namespace Lessons.Lesson6Tasks.TransportPark
{
    /// <summary>
    /// Represents the entity "diesel train" (base: RailTransport -> Transport).
    /// </summary>
    internal class DieselTrain : RailTransport
    {
        public override TypeOfEngine? EngineType { get; } = TypeOfEngine.InternalCombustion;

        public DieselTrain(string number, TypeOfTrip typeOfTrip, string pointOfDeparture, DateTime departureTime, string destination, ushort numberOfSeats) :
            base(number, typeOfTrip, pointOfDeparture, departureTime, destination, numberOfSeats) { }

        /// < summary>
        /// Overrides Transport.ToString().
        /// < /summary>
        /// < returns> 
        /// Returns the specific name of the type DieselTrain.
        /// < /returns>
        public override string ToString()
        {
            return "diesel train";
        }
    }
}
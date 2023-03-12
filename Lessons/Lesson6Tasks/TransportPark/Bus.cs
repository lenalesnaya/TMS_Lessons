namespace Lessons.Lesson6Tasks.TransportPark
{
    /// <summary>
    /// Represents the entity "bus" (base: WheeledTransport -> Transport).
    /// </summary>
    internal class Bus : WheeledTransport
    {
        public override TypeOfEngine? EngineType { get; } = TypeOfEngine.InternalCombustion;

        public Bus(string number, TypeOfTrip typeOfTrip, string pointOfDeparture, DateTime departureTime, string destination, ushort numberOfSeats) :
            base(number, typeOfTrip, pointOfDeparture, departureTime, destination, numberOfSeats) { }
    }
}
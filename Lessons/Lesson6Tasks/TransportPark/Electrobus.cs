namespace Lessons.Lesson6Tasks.TransportPark
{
    ///<summary>
    ///Represents the entity "electrobus" (base: WheeledTransport -> Transport).
    ///</summary>
    internal class Electrobus : WheeledTransport
    {
        public override TypeOfEngine? EngineType { get; } = TypeOfEngine.Hybrid;

        public Electrobus(string number, TypeOfTrip typeOfTrip, string pointOfDeparture, DateTime departureTime, string destination, ushort numberOfSeats) :
            base(number, typeOfTrip, pointOfDeparture, departureTime, destination, numberOfSeats) { }
    }
}
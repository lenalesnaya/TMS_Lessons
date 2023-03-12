namespace Lessons.Lesson6Tasks.TransportPark
{
    ///<summary>
    ///Represents the entity "trolleybus" (base: WheeledTransport -> Transport).
    ///</summary>
    internal class Trolleybus : WheeledTransport
    {
        public override TypeOfEngine? EngineType { get; } = TypeOfEngine.Electrical;

        public Trolleybus(string number, TypeOfTrip typeOfTrip, string pointOfDeparture, DateTime departureTime, string destination, ushort numberOfSeats) :
            base(number, typeOfTrip, pointOfDeparture, departureTime, destination, numberOfSeats) { }
    }
}
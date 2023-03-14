namespace Lessons.Lesson6Tasks.TransportPark
{
    ///<summary>
    ///Represents the entity "subway" (base: RailTransport -> Transport).
    ///</summary>
    internal class Subway : RailTransport
    {
        public override TypeOfEngine? EngineType { get; } = TypeOfEngine.Electrical;

        public Subway(string number, TypeOfTrip typeOfTrip, string pointOfDeparture, DateTime departureTime, string destination, ushort numberOfSeats) :
            base(number, typeOfTrip, pointOfDeparture, departureTime, destination, numberOfSeats) { }
    }
}
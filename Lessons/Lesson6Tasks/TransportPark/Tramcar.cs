namespace Lessons.Lesson6Tasks.TransportPark
{
    ///<summary>
    ///Represents the entity "tramcar" (base: RailTransport -> Transport).
    ///</summary>
    internal class Tramcar : RailTransport
    {
        public override TypeOfEngine? EngineType { get; } = TypeOfEngine.Electrical;

        public Tramcar(string number, TypeOfTrip typeOfTrip, string pointOfDeparture, DateTime departureTime, string destination, ushort numberOfSeats) :
            base(number, typeOfTrip, pointOfDeparture, departureTime, destination, numberOfSeats) { }
    }
}
namespace Lessons.Lesson6Tasks.TransportPark
{
    ///<summary>
    ///Represents the entity "minibus" (base: WheeledTransport -> Transport).
    ///</summary>
    internal class Minibus : WheeledTransport
    {
        public override TypeOfEngine? EngineType { get; } = TypeOfEngine.InternalCombustion;

        public Minibus(string number, TypeOfTrip typeOfTrip, string pointOfDeparture, DateTime departureTime, string destination, ushort numberOfSeats) :
            base(number, typeOfTrip, pointOfDeparture, departureTime, destination, numberOfSeats) { }
    }
}
namespace Lessons.Lesson6Tasks.TransportPark
{
    ///<summary>
    ///Base abstract class for all kinds of wheeled transport in public transport park (base: Transport).
    ///</summary>
    internal abstract class WheeledTransport : Transport
    {
        public override sealed TypeOfMovement? MovementType { get; } = TypeOfMovement.Wheeled;

        public WheeledTransport(string number, TypeOfTrip typeOfTrip, string pointOfDeparture, DateTime departureTime, string destination, ushort numberOfSeats) :
            base(number, typeOfTrip, pointOfDeparture, departureTime, destination, numberOfSeats) { }
    }
}
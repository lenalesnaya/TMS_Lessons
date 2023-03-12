namespace Lessons.Lesson6Tasks.TransportPark
{
    /// <summary>
    /// Base abstract class for all kinds of rail transport in public transport park (base: Transport).
    /// </summary>
    internal abstract class RailTransport : Transport
    {
        public override sealed TypeOfMovement? MovementType { get; } = TypeOfMovement.Rail;

        public RailTransport(string number, TypeOfTrip typeOfTrip, string pointOfDeparture, DateTime departureTime, string destination, ushort numberOfSeats) :
            base(number, typeOfTrip, pointOfDeparture, departureTime, destination, numberOfSeats) { }
    }
}
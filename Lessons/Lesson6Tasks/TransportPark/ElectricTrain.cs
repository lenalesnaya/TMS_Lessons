namespace Lessons.Lesson6Tasks.TransportPark
{
    ///<summary>
    ///Represents the entity "electric train" (base: RailTransport -> Transport).
    ///</summary>
    internal class ElectricTrain : RailTransport
    {
        public override TypeOfEngine? EngineType { get; } = TypeOfEngine.Electrical;

        public ElectricTrain(string number, TypeOfTrip typeOfTrip, string pointOfDeparture, DateTime departureTime, string destination, ushort numberOfSeats) :
            base(number, typeOfTrip, pointOfDeparture, departureTime, destination, numberOfSeats) { }

        ///<summary>
        ///Overrides Transport.ToString().
        ///</summary>
        ///<returns>
        ///Returns the specific name of the type ElectricTrain.
        ///</returns>
        public override string ToString()
        {
            return "electric train";
        }
    }
}
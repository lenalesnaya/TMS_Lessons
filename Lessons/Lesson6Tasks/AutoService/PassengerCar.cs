namespace Lessons.Lesson6Tasks.AutoService
{
    ///<summary>
    ///Represents the entity "passenger car" (base: Auto).
    ///</summary>
    internal class PassengerCar : Auto
    {
        public override double LoadCapacity { get; protected set; }

        public PassengerCar(string model, string number, double maxSpeed, double loadCapacity) : base(model, number, maxSpeed)
        {
            LoadCapacity = loadCapacity;
        }

        ///<summary>
        ///Sets load capacity to the specific passenger car.
        ///</summary>
        ///<param name="loadCapacity">Represents a double type value of load capacity.</param>
        public void SetLoadCapacity(double loadCapacity)
        {
            LoadCapacity = loadCapacity;
        }

        ///<summary>
        ///Overrides Auto.ToString().
        ///</summary>
        ///<returns>
        ///Returns the specific name of the type PassengerCar.
        ///</returns>
        public override string ToString()
        {
            return "passenger car";
        }
    }
}
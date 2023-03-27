namespace Lessons.Lesson10Tasks.EnginesTask
{
    ///<summary>
    ///Represents the entity "diesel car" (base: Car<DieselEngine>).
    ///</summary>
    internal class DieselCar : Car<DieselEngine>
    {
        public override DieselEngine Engine => new();

        ///<summary>
        ///Overrides Object.ToString().
        ///</summary>
        ///<returns>
        ///Returns the specific name of the type DieselCar.
        ///</returns>
        public override string ToString()
        {
            return "Diesel car";
        }
    }
}
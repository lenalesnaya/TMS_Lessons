namespace Lessons.Lesson10Tasks.EnginesTask
{
    ///<summary>
    ///Represents the entity "electric car" (base: Car<ElectricEngine>).
    ///</summary>
    internal class ElectricCar : Car<ElectricEngine>
    {
        public override ElectricEngine Engine => new();

        ///<summary>
        ///Overrides Object.ToString().
        ///</summary>
        ///<returns>
        ///Returns the specific name of the type ElectricCar.
        ///</returns>
        public override string ToString()
        {
            return "Electric car";
        }
    }
}
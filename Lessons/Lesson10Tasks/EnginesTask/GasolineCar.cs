namespace Lessons.Lesson10Tasks.EnginesTask
{
    ///<summary>
    ///Represents the entity "gasoline car" (base: Car<GasolineEngine>).
    ///</summary>
    internal class GasolineCar : Car<GasolineEngine>
    {
        public override GasolineEngine Engine => new();

        ///<summary>
        ///Overrides Object.ToString().
        ///</summary>
        ///<returns>
        ///Returns the specific name of the type GasolineCar.
        ///</returns>
        public override string ToString()
        {
            return "Gasoline car";
        }
    }
}
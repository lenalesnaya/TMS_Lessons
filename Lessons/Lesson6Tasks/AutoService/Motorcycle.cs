namespace Lessons.Lesson6Tasks.AutoService
{
    ///<summary>
    ///Represents the entity "motorcycle" (base: Auto).
    ///</summary>
    internal class Motorcycle : Auto
    {
        public override double LoadCapacity { get; protected set; } = 0.0;
        public bool Sidecar { get; protected set; } = false;

        public Motorcycle(string model, string number, double maxSpeed, double loadCapacity) : this(model, number, maxSpeed)
        {
            LoadCapacity = loadCapacity;
            Sidecar = true;
        }

        public Motorcycle(string model, string number, double maxSpeed) : base(model, number, maxSpeed) { }

        ///<summary>
        ///Overrides Auto.ShowInfo(). Uses the base implementation plus prints information about a sidecar.
        ///</summary>
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Existence of a sidecar: {(Sidecar == true ? "Yes" : "No")}");
        }

        ///<summary>
        ///Sets a sidecar and its load capacity to the specific motorcycle.
        ///</summary>
        ///<param name="loadCapacity">Represents a double type value of load capacity.</param>
        public void SetSidecar(double loadCapacity)
        {
            Sidecar = true;
            LoadCapacity = loadCapacity;
        }

        ///<summary>
        ///Cancels a sidecar and set value 0.0 to load capacity of the specific motorcycle.
        ///</summary>
        public void CancelSidecar()
        {
            Sidecar = false;
            LoadCapacity = 0.0;
        }

        ///<summary>
        ///Sets load capacity to the specific motorcycle.
        ///</summary>
        ///<param name="loadCapacity">Represents a double type value of load capacity.</param>
        public void SetLoadCapacity(double loadCapacity)
        {
            if (Sidecar)
            {
                LoadCapacity = loadCapacity;
            }
        }
    }
}
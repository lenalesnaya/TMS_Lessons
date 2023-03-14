namespace Lessons.Lesson6Tasks.AutoService
{
    ///<summary>
    ///Represents the entity "truck" (base: Auto).
    ///</summary>
    internal class Truck : Auto
    {
        private double loadCapacity;
        private bool trailer;

        public override double LoadCapacity
        {
            get { return loadCapacity; }
            protected set
            {
                if (trailer)
                {
                    loadCapacity = value * 2;
                }
                else
                {
                    loadCapacity = value;
                }
            }
        }

        public bool Trailer
        {
            get { return trailer; }
            set
            {
                if (trailer == value)
                {
                    return;
                }

                trailer = value;
                if (trailer)
                {
                    loadCapacity *= 2;
                }
                else
                {
                    loadCapacity /= 2;
                }
            }
        }

        public Truck(string model, string number, double maxSpeed, double loadCapacity, bool trailer = false) : base(model, number, maxSpeed)
        {
            this.trailer = trailer;
            SetLoadCapacity(loadCapacity);
        }

        ///<summary>
        ///Overrides Auto.ShowInfo(). Uses the base implementation plus prints information about a trailer.
        ///</summary>
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Existence of a trailer: {(trailer == true ? "Yes" : "No")}");
        }

        ///<summary>
        ///Sets load capacity to the specific truck.
        ///</summary>
        ///<param name="loadCapacity">Represents a double type value of load capacity.</param>
        public void SetLoadCapacity(double loadCapacity)
        {
            if (trailer)
            {
                this.loadCapacity = loadCapacity * 2;
            }
            else
            {
                this.loadCapacity = loadCapacity;
            }
        }
    }
}
namespace Lessons.Lesson6Tasks.AutoService
{
    internal struct AutoDb
    {
        public static Auto[] Autos { get; set; } =
        {
            new PassengerCar("Audi A4 allroad quattro B9", "AA00", 150, 2),
            new PassengerCar("Audi Q4 e-tron", "A020", 170, 1.7),
            new Motorcycle("Suzuki GSX-R 1000", "52LP", 120, 0.5),
            new Motorcycle("Yamaha YZF-R1", "8H81", 110),
            new Truck("MAN TGS M", "JH852-55", 100, 50),
            new Truck("Volvo FH", "K1022-I5", 120, 60, true)
        };
    }
}
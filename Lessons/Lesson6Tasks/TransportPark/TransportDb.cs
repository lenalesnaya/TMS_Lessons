namespace Lessons.Lesson6Tasks.TransportPark
{
    internal class TransportDb
    {
        public static Transport[] Transport { get; set; } =
        {
            new Bus(
                "2525110", TypeOfTrip.International, "Minsk", new DateTime(2023, 03, 05, 06, 10, 00), "Kyiv", 45),
            new Minibus(
                "1010", TypeOfTrip.Intercity, "Berezino", new DateTime(2023, 03, 11, 07, 10, 00), "Minsk", 22),
            new Trolleybus(
                "53", TypeOfTrip.Urban, "Green Meadow", new DateTime(2023, 03, 11, 00, 55, 00), "Silverfish", 50),
            new Tramcar(
                "53", TypeOfTrip.Urban, "Chizhovka", new DateTime(2023, 03, 11, 11, 07, 00), "Railway station", 50),
            new Tramcar(
                "53", TypeOfTrip.Urban, "RailwayStation", new DateTime(2023, 03, 11, 14, 03, 00), "Chizhovka", 50),
            new Electrobus(
                "101K2", TypeOfTrip.Intercity, "Smolevichi", new DateTime(2023, 03, 11, 10, 20, 00), "Smilovichi", 42),
            new Subway(
                "222", TypeOfTrip.Urban, "Mogilyovskaya", new DateTime(2023, 03, 12, 18, 57, 00), "Rock hill", 250),
            new ElectricTrain(
                "80T85", TypeOfTrip.Suburban, "Minsk railway station", new DateTime(2023, 03, 24, 12, 30, 00), "Gudogai", 350),
            new DieselTrain(
                "1233HH", TypeOfTrip.International, "Minsk", new DateTime(2023, 04, 02, 08, 55, 00), "Tbilisi", 550),
            new Bus(
                "2005110", TypeOfTrip.International, "Minsk", new DateTime(2023, 03, 29, 10, 00, 00), "Kyiv", 65)
        };
    }
}
using Lessons.Lesson6Tasks.TransportPark;
using Lessons.Lesson6Tasks.Clinic;
using Lessons.Lesson6Tasks.GeometricFigures;

namespace Lessons.Lesson6Tasks
{
    internal class Lesson6
    {
        public static void Task1_UseGeometricFigures()
        {
            Console.WriteLine("\nTask 1.\n");

            var arrayOfFigures = new Figure?[]
            {
                TriangleBuilder.Create(5, 5, 5),
                TriangleBuilder.Create(5, 4, 5),
                TriangleBuilder.Create(6, 8, 10),
                TriangleBuilder.Create(5, 7, 10),
                TriangleBuilder.Create(5, 5, 10),
                Foursquare.Create(10, 10),
                Foursquare.Create(7, 10),
                new Rectangle(18, 12)
            };

            foreach (var figure in arrayOfFigures)
            {
                if (figure != null)
                {
                    Console.WriteLine(figure.GetSquare().ToString("#.##"));
                }
            }
        }

        public static void Task2_UseClinic()
        {
            Console.WriteLine("\nTask 2.\n");

            var patientVolodya = new Patient("Volodya");
            patientVolodya.Treat();
            patientVolodya.CreateTreatmentPlan(
                DoctorsCodes.Therapist, DoctorsCodes.Surgeon, DoctorsCodes.Dentist, DoctorsCodes.Therapist);
            patientVolodya.Treat();
            patientVolodya.CancelTreatmentPlan();
            patientVolodya.Treat();

            var gastritisTreatmentPlan = new TreatmentPlan(
                DoctorsCodes.Therapist, DoctorsCodes.Surgeon, DoctorsCodes.Therapist);
            patientVolodya.SetTreatmentPlan(gastritisTreatmentPlan);
            patientVolodya.Treat();
        }

        public static void Task3_UseCarPark()
        {
            Console.WriteLine("\nTask 3.\n");

            var busMinskKyiv = new Bus(
                "2525110", TypeOfTrip.International, "Minsk", new DateTime(2023, 03, 29, 10, 00, 00), "Kyiv", 45);
            TransportService.PrintTransportType(busMinskKyiv);

            var minibusBerezinoMinsk = new Minibus(
                "1010", TypeOfTrip.Intercity, "Berezino", new DateTime(2023, 03, 11, 07, 10, 00), "Minsk", 22);
            TransportService.PrintTransportType(minibusBerezinoMinsk);

            var trolleybusGreenMeadowSilverfish = new Trolleybus(
                "53", TypeOfTrip.Urban, "Green Meadow", new DateTime(2023, 03, 11, 00, 55, 00), "Silverfish", 50);
            TransportService.PrintTransportType(trolleybusGreenMeadowSilverfish);

            var tramcarChizhovkaRailwayStation = new Tramcar(
                "53", TypeOfTrip.Urban, "Chizhovka", new DateTime(2023, 03, 11, 11, 07, 00), "Railway station", 50);
            TransportService.PrintTransportType(tramcarChizhovkaRailwayStation);

            var tramcarRailwayStationChizhovka = new Tramcar(
                "53", TypeOfTrip.Urban, "RailwayStation", new DateTime(2023, 03, 11, 14, 03, 00), "Chizhovka", 50);

            var electricBusSmolevichiSmilovichi = new Electrobus(
                "101K2", TypeOfTrip.Intercity, "Smolevichi", new DateTime(2023, 03, 11, 10, 20, 00), "Smilovichi", 42);
            TransportService.PrintTransportType(electricBusSmolevichiSmilovichi);

            var subwayMogilyovskayaRockHill = new Subway(
                "222", TypeOfTrip.Urban, "Mogilyovskaya", new DateTime(2023, 03, 12, 18, 57, 00), "Rock hill", 250);
            TransportService.PrintTransportType(subwayMogilyovskayaRockHill);

            var electricTrainMinskRailwayStationGudogai = new ElectricTrain(
                "80T85", TypeOfTrip.Suburban, "Minsk railway station", new DateTime(2023, 03, 24, 12, 30, 00), "Gudogai", 350);
            TransportService.PrintTransportType(electricTrainMinskRailwayStationGudogai);

            var dieselTrainMinskTbilisi = new DieselTrain(
                "1233HH", TypeOfTrip.International, "Minsk", new DateTime(2023, 04, 02, 08, 55, 00), "Tbilisi", 550);
            TransportService.PrintTransportType(dieselTrainMinskTbilisi);

            var busMinskKyiv2 = new Bus(
                "2005110", TypeOfTrip.International, "Minsk", new DateTime(2023, 03, 29, 10, 00, 00), "Kyiv", 65);

            var transportArray = new Transport[]
            {
                busMinskKyiv,
                minibusBerezinoMinsk,
                trolleybusGreenMeadowSilverfish,
                tramcarChizhovkaRailwayStation,
                tramcarRailwayStationChizhovka,
                electricBusSmolevichiSmilovichi,
                subwayMogilyovskayaRockHill,
                electricTrainMinskRailwayStationGudogai,
                dieselTrainMinskTbilisi,
                busMinskKyiv2
            };

            Transport tempTransport;
            for (int i = 0; i < transportArray.Length - 1; i++)
            {
                for (int j = i + 1; j < transportArray.Length; j++)
                {
                    if (transportArray[i].NumberOfSeats > transportArray[j].NumberOfSeats)
                    {
                        tempTransport = transportArray[i];
                        transportArray[i] = transportArray[j];
                        transportArray[j] = tempTransport;
                    }
                }
            }

            foreach (var transport in transportArray)
            {
                transport.ShowInfo();
            }

            Console.WriteLine("\nEnter departure date and time (\"dd/mm/yyyy hh:mm\" or \"yyyy-mm-dd hh:mm\"): ");
            var dateTimeIsParsed = DateTime.TryParse(Console.ReadLine(), out DateTime departureDateTime);

            Console.WriteLine("\nEnter destination: ");
            var destination = Console.ReadLine();

            var indicator = 0;
            if (dateTimeIsParsed && !string.IsNullOrEmpty(destination))
            {
                foreach (var transport in transportArray)
                {
                    if ((transport.DepartureTime == departureDateTime) && (transport.Destination == destination))
                    {
                        transport.ShowInfo();
                        indicator++;
                    }
                }

                if (indicator < 1)
                {
                    Console.WriteLine("\nNo matches found");
                }
            }
            else
            {
                Console.WriteLine("\nYou entered invalid data!");
            }

            for (int i = 0; i < transportArray.Length - 1; i++)
            {
                for (int j = i + 1; j < transportArray.Length; j++)
                {
                    if (transportArray[i].DepartureTime > transportArray[j].DepartureTime)
                    {
                        tempTransport = transportArray[i];
                        transportArray[i] = transportArray[j];
                        transportArray[j] = tempTransport;
                    }
                }
            }

            Console.WriteLine("\nEnter departure date and time (\"dd/mm/yyyy hh:mm\" or \"yyyy-mm-dd hh:mm\"): ");
            dateTimeIsParsed = DateTime.TryParse(Console.ReadLine(), out departureDateTime);

            indicator = 0;
            if (dateTimeIsParsed)
            {
                foreach (var transport in transportArray)
                {
                    if (transport.DepartureTime >= departureDateTime)
                    {
                        transport.ShowInfo();
                        indicator++;
                    }
                }

                if (indicator < 1)
                {
                    Console.WriteLine("\nNo trips found");
                }
            }
            else
            {
                Console.WriteLine("\nYou entered invalid data!");
            }

            var isTransportsEqual = tramcarChizhovkaRailwayStation.Equals(tramcarRailwayStationChizhovka) ?
                "\nTramcars are equal" :
                "\nTramcars aren`t equal";
            Console.WriteLine(isTransportsEqual);
            isTransportsEqual = tramcarChizhovkaRailwayStation.Equals(trolleybusGreenMeadowSilverfish) ?
                "\nTramcar and trolleybus are equal" :
                "\nTramcar and trolleybus aren`t equal";
            Console.WriteLine(isTransportsEqual);
            isTransportsEqual = busMinskKyiv.Equals(busMinskKyiv2) ?
                "\nBuses are equal" :
                "\nBuses aren`t equal";
            Console.WriteLine(isTransportsEqual);
        }
    }
}
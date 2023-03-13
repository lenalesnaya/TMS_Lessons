using Lessons.Lesson6Tasks.TransportPark;
using Lessons.Lesson6Tasks.Clinic;
using Lessons.Lesson6Tasks.GeometricFigures;
using Lessons.Lesson6Tasks.AutoService;

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

        public static void Task3_UseTransportPark()
        {
            Console.WriteLine("\nTask 3.\n");

            foreach (var transport in TransportDb.Transport)
            {
                TransportService.PrintTransportType(transport);
            }

            Transport tempTransport;
            for (int i = 0; i < TransportDb.Transport.Length - 1; i++)
            {
                for (int j = i + 1; j < TransportDb.Transport.Length; j++)
                {
                    if (TransportDb.Transport[i].NumberOfSeats > TransportDb.Transport[j].NumberOfSeats)
                    {
                        tempTransport = TransportDb.Transport[i];
                        TransportDb.Transport[i] = TransportDb.Transport[j];
                        TransportDb.Transport[j] = tempTransport;
                    }
                }
            }

            foreach (var transport in TransportDb.Transport)
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
                foreach (var transport in TransportDb.Transport)
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

            for (int i = 0; i < TransportDb.Transport.Length - 1; i++)
            {
                for (int j = i + 1; j < TransportDb.Transport.Length; j++)
                {
                    if (TransportDb.Transport[i].DepartureTime > TransportDb.Transport[j].DepartureTime)
                    {
                        tempTransport = TransportDb.Transport[i];
                        TransportDb.Transport[i] = TransportDb.Transport[j];
                        TransportDb.Transport[j] = tempTransport;
                    }
                }
            }

            Console.WriteLine("\nEnter departure date and time (\"dd/mm/yyyy hh:mm\" or \"yyyy-mm-dd hh:mm\"): ");
            dateTimeIsParsed = DateTime.TryParse(Console.ReadLine(), out departureDateTime);

            indicator = 0;
            if (dateTimeIsParsed)
            {
                foreach (var transport in TransportDb.Transport)
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

            var isTransportsEqual = TransportDb.Transport[3].Equals(TransportDb.Transport[4]) ?
                "\nTramcars are equal" :
                "\nTramcars aren`t equal";
            Console.WriteLine(isTransportsEqual);
            isTransportsEqual = TransportDb.Transport[3].Equals(TransportDb.Transport[2]) ?
                "\nTramcar and trolleybus are equal" :
                "\nTramcar and trolleybus aren`t equal";
            Console.WriteLine(isTransportsEqual);
            isTransportsEqual = TransportDb.Transport[0].Equals(TransportDb.Transport[9]) ?
                "\nBuses are equal" :
                "\nBuses aren`t equal";
            Console.WriteLine(isTransportsEqual);
        }

        public static void Task4_UseAutoService()
        {
            foreach (var auto in AutoDb.Autos)
            {
                auto.ShowInfo();
            }

            Console.WriteLine("\nEnter the minimum required load capacity (t): ");
            var loadCapacityIsParsed = double.TryParse(Console.ReadLine(), out double loadCapacity);

            int indicator = 0;
            if (loadCapacityIsParsed)
            {
                foreach (var auto in AutoDb.Autos)
                {
                    if (auto.LoadCapacity >= 20)
                    {
                        auto.ShowInfo();
                    }
                    indicator++;
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

            var car = new PassengerCar("Volvo V60 Cross Country", "2727", 250, 750);
            car.ShowInfo();
            car.SetLoadCapacity(600);
            car.ShowInfo();

            var motorcycle = new Motorcycle("Honda RS250RW", "N250", 150);
            motorcycle.ShowInfo();
            motorcycle.SetLoadCapacity(0.3);
            motorcycle.ShowInfo();
            motorcycle.SetSidecar(0.3);
            motorcycle.ShowInfo();
            motorcycle.CancelSidecar();
            motorcycle.ShowInfo();
            motorcycle = new Motorcycle("Ducati 1199 Panigale S", "00M1", 170, 0.5);
            motorcycle.ShowInfo();

            var truck = new Truck("Scania S-Series", "88KF3-51", 200, 30);
            truck.ShowInfo();
            truck.Trailer = true;
            truck.ShowInfo();
            truck.SetLoadCapacity(40);
            truck.ShowInfo();
            truck.Trailer = false;
            truck.ShowInfo();
            truck = new Truck("HINO 500", "300F3-HH", 210, 60, true);
            truck.ShowInfo();
            truck.Trailer = true;
            truck.ShowInfo();
            truck.SetLoadCapacity(40);
            truck.ShowInfo();
            truck.Trailer = false;
            truck.ShowInfo();
        }
    }
}
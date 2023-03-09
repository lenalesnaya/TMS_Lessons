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
                FourSquare.CreateFourSquare(10, 10),
                FourSquare.CreateFourSquare(7, 10),
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
    }
}
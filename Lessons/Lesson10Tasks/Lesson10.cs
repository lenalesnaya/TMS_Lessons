using Lessons.Lesson10Tasks.ArrayTask;
using Lessons.Lesson10Tasks.EnginesTask;
using Lessons.Lesson10Tasks.PointTask;

namespace Lessons.Lesson10Tasks
{
    internal class Lesson10
    {
        public static void Task1_UseArrayWrapper()
        {
            Console.WriteLine("\nTask 1.\n");

            var genericArray = new GenericArrayWrapper<string>
            {
                "cat",
                "dog"
            };
            genericArray.Add("mouse");

            var stringArray = new string[]
            {
                "horse",
                "cow"
            };
            genericArray.Add(stringArray);

            stringArray = new string[]
            {
                "rooster",
                "chicken"
            };

            var newGenericArray = new GenericArrayWrapper<string>(stringArray);
            genericArray.Add(newGenericArray);
            genericArray.Remove("dog");
            Console.WriteLine();
            Console.WriteLine(genericArray.GetValue(1));
            Console.WriteLine(genericArray.Length());

            Console.WriteLine();
            foreach (var item in genericArray)
            {
                Console.WriteLine(item);
            }
        }

        public static void Task2_UseEngines()
        {
            Console.WriteLine("\nTask 2.\n");

            var dieselCar = new DieselCar();
            var gasolineCar = new GasolineCar();
            var electricCar = new ElectricCar();

            dieselCar.Move();
            gasolineCar.Move();
            electricCar.Move();

            dieselCar.Fuel();
            gasolineCar.Fuel();
            electricCar.Fuel();
        }

        public static void Task3_UsePoints()
        {
            Console.WriteLine("\nTask 3.\n");

            var point1 = new DoublePoint(5, 1);
            var point2 = new DoublePoint(22, 8);
            var point3 = new DoublePoint(2, 12);

            point1.PrintCoordinates();
            point2.PrintCoordinates();
            point3.PrintCoordinates();

            var triangle = new Triangle(point1, point2, point3);
            Console.WriteLine($"\nFirstSide: {triangle.FirstSide:#.##}\nSecondSide: {triangle.SecondSide:#.##}\nThirdSide: {triangle.ThirdSide:#.##}");
            Console.WriteLine($"Square: {triangle.GetSquare():#.##}");
        }
    }
}
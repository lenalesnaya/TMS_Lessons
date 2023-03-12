namespace Lessons.Lesson6Tasks.TransportPark
{
    /// <summary>
    /// Provides methods for working with the Transport class (and its descendants).
    /// </summary>
    internal static class TransportService
    {
        /// < summary>
        /// Prints information about specific transport type to the console.
        /// < /summary>
        /// <param name="transport">The object of transport, which type information is printed.</param>
        public static void PrintTransportType(Transport transport)
        {
            transport.GetTransportType(
                out string transportName, out TypeOfMovement? movementType, out TypeOfEngine? engineType);
            Console.WriteLine(
                $"\nKind: {transportName}\nMovement type: {GetTypeOfMovementString(movementType)}\nEngine type: {GetTypeOfEngineString(engineType)}");
        }

        /// < summary>
        /// Gets the string of the type of movement.
        /// < /summary>
        /// < returns>
        /// <param name="movementType">Represents type of movement.</param>
        /// Returns the string of type of movement.
        /// < /returns>
        private static string GetTypeOfMovementString(TypeOfMovement? movementType)
        {
            return movementType switch
            {
                TypeOfMovement.Wheeled => "wheeled",
                TypeOfMovement.Rail => "rail",
                _ => "indefined",
            };
        }

        /// < summary>
        /// Gets the string of the type of engine.
        /// < /summary>
        /// < returns>
        /// <param name="movementType">Represents type of engine.</param>
        /// Returns the string of type of engine.
        /// < /returns>
        private static string GetTypeOfEngineString(TypeOfEngine? engineType)
        {
            return engineType switch
            {
                TypeOfEngine.InternalCombustion => "internal combustion",
                TypeOfEngine.Electrical => "electrical",
                TypeOfEngine.Hybrid => "hybrid",
                _ => "indefined",
            };
        }
    }
}
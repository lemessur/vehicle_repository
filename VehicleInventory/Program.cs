using System;

namespace VehicleInventory
{
    class Program
    {
        /// <summary>
        /// Program main entry point
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Execute the example
            var serviceStarter = new ExampleRunner();

            // Wait for user input before exiting
            Console.ReadKey();
        }
    }
}

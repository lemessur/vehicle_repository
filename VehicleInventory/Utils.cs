using System;
using System.Collections.Generic;

namespace VehicleInventory
{
    /// <summary>
    /// Various util functions
    /// </summary>
    public static class Utils
    {
        private static string chars = "ABCDEFGHJKLMNPRSTUVWXYZ0123456789";

        /// <summary>
        /// Debug only.
        /// Randomly generate a VIN.
        /// </summary>
        /// <returns></returns>
        public static string GenerateVIN()
        {
            var random = new Random();
            char[] buffer = new char[17];

            for (var i = 0; i < 17; ++i)
            {
                buffer[i] = chars[random.Next(chars.Length)];
            }

            return new string(buffer);
        }

        /// <summary>
        /// Print the details of a collection of vehicles to the console.
        /// </summary>
        public static void PrintVehicles(IEnumerable<Model.Vehicle> vehicles)
        {
            var sb = new System.Text.StringBuilder();

            foreach (var vehicle in vehicles)
            {
                sb.AppendLine(vehicle.ToString());
            }

            Console.Write(sb.ToString());
        }
    }
}

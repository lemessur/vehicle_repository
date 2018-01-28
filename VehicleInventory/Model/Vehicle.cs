using System;

namespace VehicleInventory.Model
{
    /// <summary>
    /// Represents a single vehicle in the inventory system.
    /// </summary>
    public class Vehicle : Entity
    {
        /// <summary>
        /// Who made this vehicle?
        /// </summary>
        public Manufacturer Manufacturer { get; set; }

        /// <summary>
        /// Ex. "Camry"
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Model year
        /// </summary>
        public UInt16 Year { get; set; }

        /// <summary>
        /// Paint color
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Vehicle Identification Number
        /// Uniquely identifies this vehicle
        /// Can be used as a key for removal
        /// </summary>
        public string VIN { get; set; }

        /// <summary>
        /// Return a string representation of this vehicle
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("Vehicle: Color: {0}, Year: {1}, Manufacturer: {2}, Model: {3}, VIN: {4}. {5}",
                Color,
                Year,
                Manufacturer == null? "Unknown" : Manufacturer.Name,
                Model,
                VIN,
                Manufacturer == null? string.Empty : Manufacturer.Comment
            );
        }
    }
}

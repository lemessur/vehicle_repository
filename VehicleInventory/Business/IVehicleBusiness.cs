using System;
using System.Collections.Generic;

using VehicleInventory.Model;

namespace VehicleInventory.Business
{
    /// <summary>
    /// Business layer interface for interacting with the vehicle inventory
    /// </summary>
    public interface IVehicleBusiness
    {
        /// <summary>
        /// Add a new vehicle to the database.
        /// </summary>
        /// <param name="vehicle"></param>
        void AddVehicle(Vehicle vehicle);

        /// <summary>
        /// Retrieve a single vehicle by its VIN
        /// </summary>
        /// <param name="vin"></param>
        /// <returns></returns>
        Vehicle GetVehicle(string vin);

        /// <summary>
        /// Remove the vehicle with the given VIN.
        /// </summary>
        /// <param name="vin"></param>
        void RemoveVehicle(string vin);

        /// <summary>
        /// Return all vehicles in inventory with the given model year
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        IEnumerable<Vehicle> GetVehiclesByYear(UInt16 year);

        /// <summary>
        /// Return all vehicles in inventory from the named manufacturer
        /// </summary>
        /// <param name="manufacturerName"></param>
        /// <returns></returns>
        IEnumerable<Vehicle> GetVehiclesByManufacturer(string manufacturerName);

        /// <summary>
        /// Return all vehicles in inventory
        /// </summary>
        /// <returns></returns>
        IEnumerable<Vehicle> GetAllVehicles();
    }
}

using System;
using System.Collections.Generic;

using VehicleInventory.Model;

namespace VehicleInventory.DataAccess
{
    /// <summary>
    /// Exposes an interface for adding/removing/retrieving vehicles based on certain criteria
    /// </summary>
    public interface IVehicleRepository : IRepository<Vehicle>
    {
        /// <summary>
        /// Retrieve a single vehicle by its VIN
        /// </summary>
        /// <param name="vin"></param>
        /// <returns></returns>
        Vehicle GetVehicleByVIN(string vin);

        /// <summary>
        /// Remove the vehicle with the given VIN.
        /// </summary>
        /// <param name="vin"></param>
        void RemoveVehicleByVIN(string vin);

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

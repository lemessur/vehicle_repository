using System;
using System.Linq;
using System.Collections.Generic;
using VehicleInventory.Model;

namespace VehicleInventory.DataAccess
{
    /// <summary>
    /// This class makes up the data access layer. In a real implementation it would make use of something like Entity Framework to
    /// interface with a SQL database. Here, the Vehicles "table" is just a static member variable.
    /// </summary>
    public class VehicleRepository : IVehicleRepository
    {
        /// <summary>
        /// Retrieve a single vehicle by its VIN
        /// Assume no collisions since VIN is supposed to be a unique identifier
        /// </summary>
        /// <param name="vin"></param>
        /// <returns></returns>
        public Vehicle GetVehicleByVIN(string vin) => _vehicles.Where(v => v.VIN == vin).FirstOrDefault();

        /// <summary>
        /// Return all vehicles from the specified manufacturer
        /// </summary>
        /// <param name="manufacturerName"></param>
        /// <returns></returns>
        public IEnumerable<Vehicle> GetVehiclesByManufacturer(string manufacturerName) => _vehicles.Where(v => v.Manufacturer.Name == manufacturerName);

        /// <summary>
        /// Return all vehicles with the specified model year
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public IEnumerable<Vehicle> GetVehiclesByYear(ushort year) => _vehicles.Where(v => v.Year == year);

        /// <summary>
        /// Remove the vehicle with the specified VIN
        /// </summary>
        /// <param name="vin"></param>
        public void RemoveVehicleByVIN(string vin) => _vehicles.RemoveAll(v => v.VIN == vin);

        /// <summary>
        /// Add a vehicle to inventory
        /// </summary>
        /// <param name="entity"></param>
        public void Create(Vehicle entity)
        {
            entity.Id = Guid.NewGuid();
            _vehicles.Add(entity);
        }

        /// <summary>
        /// Find an existing entity by unique Id
        /// </summary>
        /// <param name="id"></param>
        public Vehicle Retrieve(Guid id) => _vehicles.Where(v => v.Id == id).FirstOrDefault();

        /// <summary>
        /// Delete an existing entity by unique Id
        /// </summary>
        /// <param name="Id"></param>
        public void Delete(Guid id) => _vehicles.RemoveAll(v => v.Id == id);

        /// <summary>
        /// Return all vehicles in inventory
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Vehicle> GetAllVehicles() => _vehicles;

        /// <summary>
        /// Not necessary for this example program
        /// </summary>
        /// <param name="entity"></param>
        public void Update(Vehicle entity) => throw new NotImplementedException();

        /// <summary>
        /// NOTE: This member is intended to simulate the presence of a Vehicle table in a relational database.
        /// It would not exist in a real implementation.
        /// </summary>
        private static List<Vehicle> _vehicles = new List<Vehicle>();
    }
}

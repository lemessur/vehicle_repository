using System.Collections.Generic;
using VehicleInventory.Model;
using VehicleInventory.DataAccess;

namespace VehicleInventory.Business
{
    /// <summary>
    /// The business layer class used for managing vehicles in the inventory.
    /// </summary>
    public class VehicleBusiness : IVehicleBusiness
    {
        /// <summary>
        /// This class has a dependency on the corresponding data access layer interface, IVehicleRepository.
        /// It will be resolved by the dependency injection container and passed to the constructor for this class.
        /// </summary>
        private IVehicleRepository _vehicleRepository;

        /// <summary>
        /// Perform initializations
        /// </summary>
        /// <param name="VehicleRepository"></param>
        public VehicleBusiness(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        /// <summary>
        /// Add a new vehicle to the database.
        /// NOTE: In a real implementation, there would be logic here to resolve the Manufacturer (and probably other things as well, such as Model)
        /// from the Manufacturer table. Some kind logic would handle the "enter a new manufacturer" case, etc.
        /// </summary>
        /// <param name="vehicle"></param>
        public void AddVehicle(Vehicle vehicle) => _vehicleRepository.Create(vehicle);

        /// <summary>
        /// Retrieve a single vehicle by its VIN
        /// </summary>
        /// <param name="vin"></param>
        /// <returns></returns>
        public Vehicle GetVehicle(string vin) => _vehicleRepository.GetVehicleByVIN(vin);

        /// <summary>
        /// Return all vehicles in inventory from the named manufacturer
        /// </summary>
        /// <param name="manufacturerName"></param>
        /// <returns></returns>
        public IEnumerable<Vehicle> GetVehiclesByManufacturer(string manufacturerName) => _vehicleRepository.GetVehiclesByManufacturer(manufacturerName);

        /// <summary>
        /// Return all vehicles in inventory with the given model year
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public IEnumerable<Vehicle> GetVehiclesByYear(ushort year) => _vehicleRepository.GetVehiclesByYear(year);

        /// <summary>
        /// Remove the vehicle with the given VIN.
        /// </summary>
        /// <param name="vin"></param>
        public void RemoveVehicle(string vin) => _vehicleRepository.RemoveVehicleByVIN(vin);

        /// <summary>
        /// Return all vehicles in inventory
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Vehicle> GetAllVehicles() => _vehicleRepository.GetAllVehicles();

        /// <summary>
        /// For debug purposes. 
        /// </summary>
        public void GenerateCar()
        {
            var addCar =
                new Vehicle
                {
                    Model = "3",
                    Year = 2011,
                    Color = "Blue",
                    VIN = "1234567890",
                    Manufacturer = new Manufacturer
                    {
                        Name = "Mazda",
                        Country = "Japan",
                        Comment = "Zoom Zoom!"
                    }
                };

            addCar.VIN = Utils.GenerateVIN();
            AddVehicle(addCar);
        }
    }
}

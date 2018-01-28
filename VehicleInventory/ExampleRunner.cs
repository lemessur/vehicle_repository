using System;

using Unity;

using VehicleInventory.Business;
using VehicleInventory.DataAccess;
using VehicleInventory.Model;

namespace VehicleInventory
{
    /// <summary>
    /// Construct an example for the purpose of this coding exercise to demonstrate the functionality of the Vehicle Repository program.
    /// </summary>
    public class ExampleRunner
    {
        /// <summary>
        /// Dependency injection container
        /// </summary>
        private IUnityContainer container;

        /// <summary>
        /// Setup the container
        /// </summary>
        private void RegisterComponents()
        {
            // Data access layer classes
            container.RegisterType<IVehicleRepository, VehicleRepository>();

            // Business layer classes
            container.RegisterType<IVehicleBusiness, VehicleBusiness>();
        }

        /// <summary>
        /// 
        /// </summary>
        public ExampleRunner()
        {
            container = new UnityContainer();

            // Make sure our container will be able to resolve the necessary data access and business layer classes
            RegisterComponents();

            // Run the example!
            PerformExample();
        }

        /// <summary>
        /// Carry out the example as described in the instructions.
        /// </summary>
        private void PerformExample()
        {
            var vehicleBusiness = container.Resolve<VehicleBusiness>();

            // NOTE: See Manufacturer.cs and VehicleRepository.Create for explanations of how Manufacturer instances would be handled in a real implementation

            var tesla = new Manufacturer
            {
                Name = "Tesla",
                Country = "USA",
                Comment = "(Batteries Included!)"
            };

            var bmw = new Manufacturer
            {
                Name = "BMW",
                Country = "Germany",
                Comment = "\u00a9 BMW AG, Munich, Germany"
            };

            var mazda = new Manufacturer
            {
                Name = "Mazda",
                Country = "Japan",
                Comment = "Zoom Zoom!"
            };

            // Add some Teslas to our inventory
            for (var i = 0; i < 5; ++i)
            {
                vehicleBusiness.AddVehicle(new Vehicle
                {
                    Model = "S",
                    Year = 2018,
                    Color = "Red",
                    VIN = Utils.GenerateVIN(),
                    Manufacturer = tesla
                });
            }

            // Add some BMWs to our inventory
            for (var i = 0; i < 5; ++i)
            {
                vehicleBusiness.AddVehicle(new Vehicle
                {
                    Model = "i3",
                    Year = 2017,
                    Color = "Blue",
                    VIN = Utils.GenerateVIN(),
                    Manufacturer = bmw
                });
            }

            // Add some Mazdas to our inventory
            for (var i = 0; i < 5; ++i)
            {
                vehicleBusiness.AddVehicle(new Vehicle
                {
                    Model = "3",
                    Year = 2016,
                    Color = "Black",
                    VIN = Utils.GenerateVIN(),
                    Manufacturer = mazda
                });
            }

            var allVehicles = vehicleBusiness.GetAllVehicles();

            Console.WriteLine("Here are all of the vehicles in inventory:");
            Utils.PrintVehicles(allVehicles);

            // var teslas = vehicleBusiness.GetVehiclesByManufacturer("Tesla");
            var bmws = vehicleBusiness.GetVehiclesByManufacturer("BMW");

            Console.WriteLine("Here are the BMWs:");
            Utils.PrintVehicles(bmws);

            //var s = new System.Diagnostics.Stopwatch();
            //s.Start();
            //for (var i = 0; i < 10000; ++i)
            //{
            //    vehicleBusiness.GenerateCar();
            //}
            //s.Stop();
            //Console.WriteLine("ms: " + (s.ElapsedMilliseconds));

            //var mazdas = vehicleBusiness.GetVehiclesByManufacturer("Mazda");
            //foreach (var car in mazdas)
            //{
            //    Console.WriteLine(car.ToString());
            //    Console.ReadKey();
            //}
        }
    }
}

using System;
using Xunit;

using VehicleInventory;

namespace VehicleTests
{
    public class UnitTest1
    {
        [Fact]
        public void CreateRunner()
        {
            var runner = new ExampleRunner();

            Assert.NotNull(runner);

            // Assert.Null(runner);
        }

        [Fact]
        public void RunTests()
        {
            var runner = new ExampleRunner();

            runner.PerformExample();

            Assert.NotEmpty(runner.AllVehicles);
        }
    }
}

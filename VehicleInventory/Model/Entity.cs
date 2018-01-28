using System;

namespace VehicleInventory.Model
{
    /// <summary>
    /// The base class that all entity types (Vehicle, Manufacturer, etc.) inherit from.
    /// </summary>
    public abstract class Entity
    {
        /// <summary>
        /// Unique Id for this entity. In a fully implemented system with a real SQL database, this would serve as the primary key for each entity table.
        /// </summary>
        public Guid Id { get; set; }
    }
}

namespace VehicleInventory.Model
{
    /// <summary>
    /// Represents a single manufacturer in the inventory system.
    /// NOTE: In a real implementation, this class would be derived from Entity like Vehicle is and would have its own corresponding ManufacturerRepository
    /// class and interface derived from IRepository. The mapping framework would then define a many-to-one relationship between Vehicle and Manufacturer.
    /// (Or more likely, Model would also be its own Entity-derived class and the Vehicle class would reference it rather than Manufacturer directly)
    /// </summary>
    public class Manufacturer
    {
        /// <summary>
        /// Manufacturer name. Ex. Tesla, BMW.
        /// This is a unique key.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Country this manufacturer is based in.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Additional comment field. Ex. "(Batteries Included!)"
        /// 
        /// NOTE: Alternatively, depending on how much custom functionality is needed for different manufacturers, it may make sense to
        /// mark this field as virtual and overriding it in derived classes corresponding to each manufacturer. Note the lack of a set attribute
        /// 
        /// For example:
        ///
        /// public class Tesla : Manufacturer
        /// {
        ///     public override string Comment
        ///     {
        ///         get
        ///         {
        ///             return "(Batteries Included!)";
        ///         }
        ///     }
        /// }
        /// 
        /// </summary>
        public virtual string Comment { get; set; }
    }
}
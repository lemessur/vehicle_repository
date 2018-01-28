using System;
using System.Collections.Generic;
using System.Text;

using VehicleInventory.Model;

namespace VehicleInventory.DataAccess
{
    /// <summary>
    /// Provides the basic CRUD blueprint for a type-specific data access layer class.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> where T : Entity 
    {       
        /// <summary>
        /// Add a new entity to the database
        /// </summary>
        /// <param name="entity"></param>
        void Create(T entity);

        /// <summary>
        /// Find an existing entity by unique Id
        /// </summary>
        /// <param name="id"></param>
        T Retrieve(Guid id);

        /// <summary>
        /// Modify an existing entity
        /// </summary>
        /// <param name="entity"></param>
        void Update(T entity);

        /// <summary>
        /// Delete an existing entity by unique Id
        /// </summary>
        /// <param name="Id"></param>
        void Delete(Guid Id);
    }
}

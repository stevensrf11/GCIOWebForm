using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Entities;

namespace DataLayer.Service.Interfaces.Repository
{
    public interface IDLCommandRepository<T> : IDLRepository<T> where T : IDLEntity
	{
		/// <summary>
		/// Gets the by id.
		/// </summary>
		/// <param name="id">The id.</param>
		/// <returns></returns>
		T GetById(long id);

        /// <summary>
        /// Gets the by id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns></returns>
        T GetById(string id);

        /// <summary>
        /// Adds the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        T Add(T entity);

		/// <summary>
		/// Updates the specified entity.
		/// </summary>
		/// <param name="entity">The entity.</param>
		void Update(T entity);

		/// <summary>
		/// Deletes the specified entity.
		/// </summary>
		/// <param name="entity">The entity.</param>
		void Delete(T entity);

		/// <summary>
		/// Deletes the specified id.
		/// </summary>
		/// <param name="id">The id.</param>
		void Delete(long id);

		///// <summary>
		///// Refreshes the specified entity cache.
		///// </summary>
		///// <param name="entity">The entity.</param>
		//void Refresh(T entity);

		/// <summary>
		/// Units the of work.
		/// </summary>
		/// <returns></returns>
		//IDLUnitOfWork UnitOfWork();
	}
}

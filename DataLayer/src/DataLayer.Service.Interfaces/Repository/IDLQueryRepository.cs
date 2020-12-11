using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Entities;

namespace DataLayer.Service.Interfaces.Repository
{
    /// <summary>
    /// Select query repository interface derived from the <see cref="IDLRepository<typeparamref name="T"/>"/>
    /// Supposrts the use of <see cref="IQueryable"/> interface
    /// on entities object where the entity which are derved from <see cref="IDLEntity"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IDLQueryRepository<T> : IDLRepository<T> where T : IDLEntity
	{
		/// <summary>
		/// Gets all.
		/// </summary>
		/// <returns></returns>
		IQueryable<T> GetAll();

		/// <summary>
		/// Gets the specified where.
		/// </summary>
		/// <param name="where">The where.</param>
		/// <returns></returns>
		IQueryable<T> Get(Func<T, bool> where);

		/// <summary>
		/// Gets the specified expression.
		/// </summary>
		/// <param name="where">The expression.</param>
		/// <returns></returns>
		IQueryable<T> GetQuery();

	}

}

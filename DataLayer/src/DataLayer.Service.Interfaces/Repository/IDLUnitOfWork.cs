using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Service.Interfaces.Repository
{
    public interface IDLUnitOfWork
	{
		/// <summary>
		/// Saves this instance.
		/// </summary>
		int Save();


		/// <summary>
		/// Refresh the repository.
		/// </summary>
		void Refresh();

	}
}

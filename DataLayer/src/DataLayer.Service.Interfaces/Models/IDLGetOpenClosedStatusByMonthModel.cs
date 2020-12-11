using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Service.Interfaces.Models
{
    /// <summary>
    /// Data layer total open and closed interface model
    /// for a given month
    /// Derived from interface <see cref="IDLModel"/>
    /// </summary>
    public interface IDLGetOpenClosedStatusByMonthModel : IDLModel
    {
        #region Accessor Properties
        /// <summary>
        /// Date time for reports
        /// </summary>
        DateTimeOffset? DateTime { get; set; }

        /// <summary>
        /// Total number of reports opened for a given month
        /// </summary>
         Int32? TotalOpen { get; set; }

        /// <summary>
        /// Total number of reports closed for a given month
        /// </summary>
        Int32? TotalClosed { get; set; }
        #endregion
    }
}

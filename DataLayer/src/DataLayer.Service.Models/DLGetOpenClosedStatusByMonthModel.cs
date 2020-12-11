using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Service.Interfaces.Models;

namespace DataLayer.Service.Models
{

    /// <summary>
    /// Data layer total open and closed concrete class model
    /// for a given month
    /// Derived from class <seealso cref="DLModel"/>
    /// Derived from interface <seealso cref="IDLGetOpenClosedStatusByMonthModel"/>
    /// </summary>
    public class DLGetOpenClosedStatusByMonthModel : DLModel
        ,IDLGetOpenClosedStatusByMonthModel
    {
        #region Accessor Properties
        /// <summary>
        /// Date time for reports
        /// </summary>
        public DateTimeOffset? DateTime { get; set; }

        /// <summary>
        /// Total number of reports opened for a given month
        /// </summary>
        public Int32? TotalOpen { get; set; }

        /// <summary>
        /// Total number of reports closed for a given month
        /// </summary>
        public Int32? TotalClosed { get; set; }
        #endregion
    }
}

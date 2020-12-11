using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Service.Interfaces.Models
{

    /// <summary>
    /// Data layer supplier open day interface model
    /// Contains the number of days open for a given period of day
    /// Derived from interface <see cref="IDLModel"/>
    /// </summary>
    public interface IDLGetDaysOpenSortBySupplierModel : IDLModel
    {
        #region Accessor Properties
        /// <summary>
        /// Name of supplier
        /// </summary>
        String SupplierName { get; set; }
        /// <summary>
        /// Supplier code
        /// </summary>
         String SupplierCode { get; set; }

        /// <summary>
        /// Number of open reports less than seven day period
        /// </summary>
         Int32? Day7 { get; set; }

        /// <summary>
        /// Number of open reports greater or equal to seven days but less than thirty day period
        /// </summary>
        Int32? Day30 { get; set; }

        /// <summary>
        /// Number of open reports greater or equal to thirty days but less than sixty day period
        /// </summary>
        Int32? Day60 { get; set; }

        /// <summary>
        /// Number of open reports greater or equal to sixty days but less than ninety day period
        /// </summary>
        Int32? Day90 { get; set; }

        /// <summary>
        /// Number of open reports greater or equal to ninety days but less than 120 day period
        /// </summary>
        Int32? Day120 { get; set; }

        /// <summary>
        /// Number of open reports greater or equal to  120 day period
        /// </summary>
         Int32? Day120Plus { get; set; }
        #endregion
    }
}

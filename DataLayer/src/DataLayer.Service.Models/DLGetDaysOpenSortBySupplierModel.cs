using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Service.Interfaces.Models;

namespace DataLayer.Service.Models
{
    /// <summary>
    /// Data layer supplier open day  model
    /// Contains the number of days open for a given period of day
    /// Derived from vase model class <see cref="DLModel"/> and the interface <seealso cref="IDLGetDaysOpenSortBySupplierModel"/>
    /// </summary>s
    public class DLGetDaysOpenSortBySupplierModel :DLModel
        , IDLGetDaysOpenSortBySupplierModel
    {
        #region Accessor Properties
        /// <summary>
        /// Name of supplier
        /// </summary>
       public  String SupplierName { get; set; }
        /// <summary>
        /// Supplier code
        /// </summary>
        public String SupplierCode { get; set; }

        /// <summary>
        /// Number of open reports less than seven day period
        /// </summary>
        [Display(Order=0,ShortName="DayOpen07")]
        public Int32? Day7 { get; set; }

        /// <summary>
        /// Number of open reports greater or equal to seven days but less than thirty day period
        /// </summary>
        [Display(Order = 1, ShortName = "DayOpen30")]

        public Int32? Day30 { get; set; }

        /// <summary>
        /// Number of open reports greater or equal to thirty days but less than sixty day period
        /// </summary>
        [Display(Order = 2, ShortName = "DayOpen60")]
        public Int32? Day60 { get; set; }

        /// <summary>
        /// Number of open reports greater or equal to sixty days but less than ninety day period
        /// </summary>
        [Display(Order = 3, ShortName = "DayOpen90")]
        public Int32? Day90 { get; set; }

        /// <summary>
        /// Number of open reports greater or equal to ninety days but less than 120 day period
        /// </summary>
        [Display(Order = 4, ShortName = "DayOpen120")]
        public Int32? Day120 { get; set; }

        /// <summary>
        /// Number of open reports greater or equal to  120 day period
        /// </summary>
        [Display(Order = 5, ShortName = "DayOpen121")]
        public Int32? Day120Plus { get; set; }
        #endregion
    }
}

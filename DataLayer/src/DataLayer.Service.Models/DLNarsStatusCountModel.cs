using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Service.Interfaces.Models;

namespace DataLayer.Service.Models
{
    /// <summary>
    /// Data layer nar status count class
    /// Contains the number of various total status counts
    /// Derived from class <see cref="DLModel"/>
    /// Derived from interface <seealso cref="IDLNarsStatusCountModel"/>
    /// </summary>

    public class DLNarsStatusCountModel :DLModel
    , IDLNarsStatusCountModel
    {
        #region Accessor Properties
        /// <summary>
        /// Total number of status closed
        /// </summary>
        public int TotalClosed { get; set; }

        /// <summary>
        /// Total number of status open
        /// </summary>
        public int TotalOpen { get; set; }

        /// <summary>
        /// Total number of status pending
        /// </summary>
        public int TotalPending { get; set; }

        /// <summary>
        /// Total number of status pending cm approval
        /// </summary>
        public int TotalPendingCmApp { get; set; }


        /// <summary>
        /// Total number of open, closed, pending, and pending cm approval
        /// statuses which are of report  type value HTR
        /// </summary>
        public int TotalHTR { get; set; }

        /// <summary>
        /// Total number of open, closed, pending, and pending cm approval
        /// </summary>
        public int Total { get; set; }

        /// <summary>
        /// Name of who total status results belong to 
        /// </summary>
        public string AssociateName { get; set; }

        /// <summary>
        /// UserId
        /// </summary>
        public string AssociateClock { get; set; }
        #endregion

    }
}

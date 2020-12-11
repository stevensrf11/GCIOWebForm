using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Service.Interfaces.Models
{
    /// <summary>
    /// Data layer nar status count interface
    /// Contains the number of various total status counts
    /// Derived from interface <see cref="IDLModel"/>
    /// </summary>
    public interface IDLNarsStatusCountModel :IDLModel
    {
        #region Accessor Properties
        /// <summary>
        /// Total number of status closed
        /// </summary>
        int TotalClosed { get; set; }

        /// <summary>
        /// Total number of status open
        /// </summary>
        int TotalOpen { get; set; }

        /// <summary>
        /// Total number of status pending
        /// </summary>
        int TotalPending { get; set; }

        /// <summary>
        /// Total number of status pending cm approval
        /// </summary>
        int TotalPendingCmApp { get; set; }


        /// <summary>
        /// Total number of open, closed, pending, and pending cm approval
        /// statuses which are of report  type value HTR
        /// </summary>
        int TotalHTR { get; set; }

        /// <summary>
        /// Total number of open, closed, pending, and pending cm approval
        /// </summary>
        int Total { get; set; }

        /// <summary>
        /// Name of who total status results belong to 
        /// </summary>
         string AssociateName { get; set; }

         string AssociateClock { get; set; }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using DataLayer.Service.Interfaces.Models;

namespace DataLayer.Service.Models
{
    /// <summary>
    /// DLNarsStatusInputModel data layer input model derived from the
    /// class <see cref="DLModel"/>, and the interface <seealso cref="IDLNarsStatusInputModel"/>
    /// Used for retrieving nars status information for based on a list og group names, list of statuses,
    /// a date range span, a team code and sub-team code value
    /// </summary>
    public class DLNarsStatusInputModel :DLModel
        , IDLNarsStatusInputModel
    {
        /// <summary>
        /// List of group names
        /// </summary>
        public IList<IDLGetStatusCountInputModel> GroupNames { get; set; }

        /// <summary>
        /// List of statuses
        /// </summary>
        public IList<string> HTRStatus { get; set; }



    }

    /// <summary>
    /// DLNarsStatusUserInputModel data layer input model derived from the
    /// class <see cref="DLNarsStatusInputModel"/>, and the interface <seealso cref="IDLNarsStatusUserInputModel"/>
    /// Used for retrieing nars status information for a given list of users
    /// </summary>
    public class DLNarsStatusUserInputModel : DLNarsStatusInputModel
        , IDLNarsStatusUserInputModel
    {
        /// <summary>
        /// List of user identfications
        /// </summary>
        public IList<string> Users { get; set; }
    }
}

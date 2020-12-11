using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Service.Interfaces.Models;

namespace DataLayer.Service.Models
{
    /// <summary>
    /// Get status count class model used as input filtering information
    /// for obtaining different type status counts
    /// Derived from class <see cref="DLModel"/>
    /// Derived from interface <seealso cref="IDLGetStatusCountInputModel"/>
    /// </summary>
    public class DLGetStatusCountInputModel : DLModel
    , IDLGetStatusCountInputModel
    {
        /// <summary>
        /// Group name
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// Group Name Code
        /// </summary>
        public string GroupCode { get; set; }

        /// <summary>
        /// Team code
        /// </summary>
        public string TeamCode { get; set; }

        /// <summary>
        /// Sub team code
        /// </summary>
        public string SubTeamCode { get; set; }

        /// <summary>
        /// Starting date a status was issued
        /// </summary>
        public DateTimeOffset? IssuedStartDateTime { get; set; }

        /// <summary>
        /// Ending date a status was issued
        /// </summary>
        public DateTimeOffset? IssuedEndDateTime { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Service.Interfaces.Models
{

    /// <summary>
    /// Data layer get  status count interface model used as input filtering information
    /// for obtaining different type status counts
    /// Derived from interface <see cref="IDLModel"/>
    /// </summary>
    public interface IDLGetStatusCountInputModel : IDLModel
    {
        /// <summary>
        /// Group name
        /// </summary>
        string GroupName { get; set; }

        /// <summary>
        /// Group Name Code
        /// </summary>
        string GroupCode { get; set; }

        /// <summary>
        /// Team code
        /// </summary>
        string TeamCode { get; set; }

        /// <summary>
        /// Sub team code
        /// </summary>
        string SubTeamCode { get; set; }

        /// <summary>
        /// Starting date a status was issued
        /// </summary>
        DateTimeOffset? IssuedStartDateTime { get; set; }

        /// <summary>
        /// Ending date a status was issued
        /// </summary>
        DateTimeOffset? IssuedEndDateTime {get;set;}

    }    
}

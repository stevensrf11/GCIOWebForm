using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Service.Interfaces.Models.AspNet;

namespace DataLayer.Service.Models.AspNet
{
    /// <summary>
    /// Data layer AspNetModel concrete class derived from <see cref=DLModel"/> class
    /// and <seealso cref="IDLAspNetUserModel"/> interface
    /// Providesinformation about a user
    /// </summary>
    public class DLAspNetUserModel :DLModel
    , IDLAspNetUserModel
    {
        /// <summary>
        /// List of users id's allowed to view
        /// </summary>
        public IList<string> Views { get; set; }

        /// <summary>
        /// Users name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// User's position
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// User's role
        /// </summary>
        public string Role { get; set; }
    }
}

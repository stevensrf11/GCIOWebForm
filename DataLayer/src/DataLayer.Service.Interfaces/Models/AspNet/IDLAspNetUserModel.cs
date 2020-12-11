using System.Collections.Generic;

namespace DataLayer.Service.Interfaces.Models.AspNet
{
    /// <summary>
    /// Data layer AspNetModel interface derived from <see cref="IDLModel"/>
    /// Providesinformation about a user
    /// </summary>
    public interface IDLAspNetUserModel :IDLModel
    {
        /// <summary>
        /// List of users id's allowed to view
        /// </summary>
        IList<string> Views { get; set; }

        /// <summary>
        /// Users name
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// User's position
        /// </summary>
        string Position { get; set; }

        /// <summary>
        /// User's role
        /// </summary>
         string Role { get; set; }

    }
}

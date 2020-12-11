using System;

namespace DataLayer.Service.Interfaces.Models
{
    /// <summary>
    /// Data layer Days open last maintenance count interface model
    /// Number of days open are group in day ranges
    /// Last maintenance is group in greater then certain days
    /// Derived from interface <see cref="IDLModel"/>
    /// </summary>
    public interface IDLGetNarsDaysOpenLmModel  :IDLModel
    {
        #region Accessor Properties
        /// <summary>
        /// Name that count day open and last maintenance associated with
        /// </summary>
        String AssociateName { get; set; }

        /// <summary>
        /// Name that count day open and last rank associated with
        /// </summary>
        string Rank { get; set; }

        /// <summary>
        /// Number of last maintanence day greater  14 days
        /// </summary>
        int? LMGT14 { get; set; }

         /// <summary>
        /// Number of days open less than or equal to 30 days
        /// </summary>
        int? ODLTE30 { get; set; }

        /// <summary>
        /// Number of days open greater  30 days
        /// and less than or equal to 60 days
        /// </summary>
        int? ODGT30LTE60 { get; set; }

        /// <summary>
        /// Number of days open greater  60 days
        /// and less than or equal to 90 days
        /// </summary>
        int? ODGT60LTE90 { get; set; }

        /// <summary>
        /// Number of days open greater  90 days
        /// and less than or equal to 120 days
        /// </summary>
        int? ODGT90LTE120 { get; set; }

        /// <summary>
        /// Number of days open greater  120 days
        /// </summary>
        int? ODGT120 { get; set; }
        #endregion
    }
}

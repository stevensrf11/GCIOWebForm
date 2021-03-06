﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Service.Interfaces.Models;

namespace DataLayer.Service.Models
{
    /// <summary>
    /// Data layer Days open last maintenance count class model
    /// Number of days open are group in day ranges
    /// Last maintenance is group in greater then certain days
    /// Derived from class <see cref="DLModel"/>
    /// Derived from interface <seealso cref="IDLGetNarsDaysOpenLmModel"/>
    /// </summary>
    public class DLGetNarsDaysOpenLmModel :DLModel
    , IDLGetNarsDaysOpenLmModel
    {
        #region Accessor Properties
        /// <summary>
        /// Name that count day open and last maintenance associated with
        /// </summary>
        public String AssociateName { get; set; }

        /// <summary>
        /// Name that count day open and last rank associated with
        /// </summary>
        public string Rank { get; set; }

        /// <summary>
        /// Number of last maintanence day greater  14 days
        /// </summary>
        public int? LMGT14 { get; set; }

        /// <summary>
        /// Number of days open less than or equal to 30 days
        /// </summary>
        public int? ODLTE30 { get; set; }

        /// <summary>
        /// Number of days open greater  30 days
        /// and less than or equal to 60 days
        /// </summary>
        public int? ODGT30LTE60 { get; set; }

        /// <summary>
        /// Number of days open greater  60 days
        /// and less than or equal to 90 days
        /// </summary>
        public int? ODGT60LTE90 { get; set; }

        /// <summary>
        /// Number of days open greater  90 days
        /// and less than or equal to 120 days
        /// </summary>
        public int? ODGT90LTE120 { get; set; }

        /// <summary>
        /// Number of days open greater  120 days
        /// </summary>
        public int? ODGT120 { get; set; }
        #endregion

    }
}

using System;
using DataLayer.Service.Interfaces.Models;

namespace DataLayer.Service.Models
{
    /// <summary>
    /// Nars status model concrete object derived from <see cref="DLModel"/> and <seealso cref="IDLNarsStatusModel"/>
    /// </summary>
    public class DLNarsStatusModel :DLModel
        , IDLNarsStatusModel
    {
        public string AssociateClock { get; set; }
        public string GroupName { get; set; }
        public string RankCode { get; set; }
        public string AssociateName { get; set; }
        public DateTime? IssueTimestamp { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? ClosureDate { get; set; }
        public DateTime? OriginalDueDate { get; set; }
        public DateTime? OriginalClosureDate { get; set; }
        public int? DaysOpen { get; set; }
        public int? DaysSinceLastMaintain { get; set; }
        public int? DaysPastDue { get; set; }
        public string HTRStatus { get; set; }
        public string ReportTypeValue { get; set; }

        public string ReportNumber { get; set; }
        public string GroupCode { get; set; }
    }
}

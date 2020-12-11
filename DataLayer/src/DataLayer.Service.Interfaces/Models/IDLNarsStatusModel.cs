using System;

namespace DataLayer.Service.Interfaces.Models
{
    /// <summary>
    /// Interface for the Nars Status  Model
    /// </summary>
    public interface IDLNarsStatusModel :IDLModel
    {
        // RESPONSIBLE_ASSOCIATE_CLOCK [varchar] (500) NULL,
        string AssociateClock { get; set; }

        // [RESPONSIBLE_GROUP_NAME] [varchar] (500) NULL,
        string GroupName { get; set; } // RESPONSIBLE_GROUP_NAME (length: 500)

        // [RESPONSIBLE_GROUP_CODE] [varchar] (500) NULL,
         string RankCode { get; set; } // RESPONSIBLE_GROUP_CODE (length: 500)

        //[RESPONSIBLE_ASSOCIATE_NAME] [varchar] (500) NULL,
         string AssociateName { get; set; } // RESPONSIBLE_ASSOCIATE_NAME (length: 500)

        //
         DateTime? IssueTimestamp { get; set; } // ISSUE_TIMESTAMP[ISSUE_TIMESTAMP] [datetime] NULL,

        DateTime? DueDate { get; set; } // DUE_DATE [DUE_DATE] [datetime] NULL,
         DateTime? ClosureDate { get; set; } // CLOSURE_DATE[CLOSURE_DATE] [datetime] NULL,
         DateTime? OriginalDueDate { get; set; } // ORIGINAL_DUE_DATE
         DateTime? OriginalClosureDate { get; set; } // ORIGINAL_CLOSURE_DATE    

         int? DaysOpen { get; set; } // DAYS_OPEN[DAYS_OPEN] [int] NULL,
         int? DaysSinceLastMaintain { get; set; } // DAYS_SINCE_LAST_MAINTAIN   [DAYS_SINCE_LAST_MAINTAIN] [int] NULL,
         int? DaysPastDue { get; set; } // DAYS_PAST_DUE  [DAYS_PAST_DUE] [int] NULL,    
         string HTRStatus { get; set; }

          string ReportTypeValue { get; set; }

          string ReportNumber { get; set; }

          string GroupCode { get; set; }

    }
}

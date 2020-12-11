using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
 
    public partial class Read_Only_GetNarsStatusModel
    {

        // [RESPONSIBLE_GROUP_NAME] [varchar] (500) NULL,
        public string RESPONSIBLE_GROUP_NAME { get; set; } // RESPONSIBLE_GROUP_NAME (length: 500)

        // [RESPONSIBLE_GROUP_CODE] [varchar] (500) NULL,
        public string RANK_CODE { get; set; } // RESPONSIBLE_GROUP_CODE (length: 500)

        //[RESPONSIBLE_ASSOCIATE_NAME] [varchar] (500) NULL,
        public string RESPONSIBLE_ASSOCIATE_NAME { get; set; } // RESPONSIBLE_ASSOCIATE_NAME (length: 500)

        //
        public System.DateTime? ISSUE_DATE { get; set; } // ISSUE_TIMESTAMP[ISSUE_TIMESTAMP] [datetime] NULL,

        public System.DateTime? DUE_DATE { get; set; } // DUE_DATE [DUE_DATE] [datetime] NULL,
        public System.DateTime? CLOSURE_DATE { get; set; } // CLOSURE_DATE[CLOSURE_DATE] [datetime] NULL,
        public System.DateTime? ORIGINAL_DUE_DATE { get; set; } // ORIGINAL_DUE_DATE
        public System.DateTime? ORIGINAL_CLOSURE_DATE { get; set; } // ORIGINAL_CLOSURE_DATE    

        public int? DAYS_OPEN { get; set; } // DAYS_OPEN[DAYS_OPEN] [int] NULL,
        public int? DAYS_SINCE_LAST_MAINTAIN { get; set; } // DAYS_SINCE_LAST_MAINTAIN   [DAYS_SINCE_LAST_MAINTAIN] [int] NULL,
        public int? DAYS_PAST_DUE { get; set; } // DAYS_PAST_DUE  [DAYS_PAST_DUE] [int] NULL,      

        public string HTR_STATUS_VALUE { get; set; }

        public string REPORT_TYPE_VALUE { get; set; }


        public string Report_Number { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities.Entity
{
    public partial class  WrapperGetNarsStatusReturnModel
    {
        public System.String RESPONSIBLE_ASSOCIATE_NAME { get; set; }
        public System.String RESPONSIBLE_GROUP_NAME { get; set; }
        public System.String RESPONSIBLE_GROUP_CODE { get; set; }
        public System.String RESPONSIBLE_ASSOCIATE_CLOCK { get; set; }
        public System.String RANK_CODE { get; set; }
        public System.DateTime? ISSUE_DATE { get; set; }
        public System.DateTime? DUE_DATE { get; set; }
        public System.DateTime? CLOSURE_DATE { get; set; }
        public System.Int32? DAYS_OPEN { get; set; }
        public System.Int32? DAYS_PAST_DUE { get; set; }
        public System.Int32? DAYS_SINCE_LAST_MAINTAIN { get; set; }
        public System.String HTR_STATUS_VALUE { get; set; }
        public System.String REPORT_TYPE_VALUE { get; set; }
        public System.String REPORT_NUMBER { get; set; }
    }
}

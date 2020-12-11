using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Service.Interfaces.Models;
using DataLayer.Service.Models;

namespace DataLayer.Service.Models
{
    public class DLGetNarsReportComparedReturnModel :DLModel
        , IDLGetNarsReportComparedReturnModel
    {
        public string ReportName { get; set; }
        public int? ReportCount { get; set; }

        public string ReportDescription { get; set; }
    }
}

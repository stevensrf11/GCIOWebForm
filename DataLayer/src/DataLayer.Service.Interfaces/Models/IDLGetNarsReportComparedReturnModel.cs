using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Service.Interfaces.Models
{
    public interface IDLGetNarsReportComparedReturnModel : IDLModel
    {
         String ReportName { get; set; }
         Int32? ReportCount { get; set; }

         string ReportDescription { get; set; }

    }
}

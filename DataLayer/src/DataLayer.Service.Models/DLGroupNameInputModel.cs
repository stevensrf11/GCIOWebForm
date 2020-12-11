using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Service.Interfaces.Models;

namespace DataLayer.Service.Models
{
    public class DLGroupNameInputModel :DLModel
    , IDLGroupNameInputModel
    {
        public string TeamCode { get; set; }
        public string SubTeamCode { get; set; }
    }
}

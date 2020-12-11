using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Service.Interfaces;
using DataLayer.Service.Interfaces.Models;

namespace DataLayer.Service.Models
{
    public class DLGetOpenClosedPendingAllModel : DLModel
        , IDLGetOpenClosedPendingAllModel
    {
        public String AssociateName { get; set; }
        public System.String GroupName { get; set; }
        public System.Int32? TotalOpen { get; set; }
        public System.Int32? TotalClosed { get; set; }
        public System.Int32? TotalPending { get; set; }
    }
}

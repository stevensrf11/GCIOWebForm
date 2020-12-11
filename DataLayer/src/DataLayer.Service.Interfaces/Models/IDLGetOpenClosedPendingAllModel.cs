using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Service.Interfaces.Models
{
    public interface IDLGetOpenClosedPendingAllModel : IDLModel
    {
        String AssociateName { get; set; }
        System.String GroupName { get; set; }
        System.Int32? TotalOpen { get; set; }
        System.Int32? TotalClosed { get; set; }
        System.Int32? TotalPending { get; set; }
    }
}

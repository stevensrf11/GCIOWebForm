using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Service.Interfaces.Models;

namespace DataLayer.Service.Models
{
    /// <summary>
    /// Data layer Get open close status by month concrete class input model
    /// Derived from class <see cref="DLNarsStatusInputModel"/>
    /// Derived from interface <seealso cref="IDLGetOpenClosedStatusByMonthInputModel"/>
    /// </summary>
    public class DLGetOpenClosedStatusByMonthInputModel : DLNarsStatusInputModel
        , IDLGetOpenClosedStatusByMonthInputModel
    {
    }
}

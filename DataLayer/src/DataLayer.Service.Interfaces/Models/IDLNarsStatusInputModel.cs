using System;
using System.Collections.Generic;

namespace DataLayer.Service.Interfaces.Models
{
    public interface IDLNarsStatusInputModel : IDLModel
    {
        IList<IDLGetStatusCountInputModel> GroupNames { get; set; }
        IList<string> HTRStatus { get; set; }

    

    }

    public interface IDLNarsStatusUserInputModel : IDLNarsStatusInputModel
    {
        IList<string> Users { get; set; }
    }


}

using System;

namespace DataLayer.Service.Interfaces
{
    public interface IDLModel
    {
         long Id { get; set; }
         string GuidId { get; set; }
         string UserId { get; set; }

        Byte[] TimeStamp { get; set; }
    }
}

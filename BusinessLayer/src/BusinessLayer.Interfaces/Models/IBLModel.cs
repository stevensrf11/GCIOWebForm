using System;

namespace BusinessLayer.Interfaces.Models
{
    public interface IBLModel
    {
         long Id { get; set; }
         string GuidId { get; set; }
         string UserId { get; set; }

        Byte[] TimeStamp { get; set; }
    }
}

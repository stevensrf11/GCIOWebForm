using DataLayer.Service.Interfaces;

namespace DataLayer.Service.Models
{
    public class DLModel : IDLModel
    {
        public byte[] TimeStamp { get; set; }
        public long Id { get; set; }
        public string GuidId { get; set; }

        public string UserId { get; set; }
    }
}

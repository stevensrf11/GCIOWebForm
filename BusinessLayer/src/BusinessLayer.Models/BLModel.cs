using BusinessLayer.Interfaces.Models;

namespace BusinessLayer.Models
{ 
    public class BLModel : IBLModel
    {
        public byte[] TimeStamp { get; set; }
        public long Id { get; set; }
        public string GuidId { get; set; }

        public string UserId { get; set; }
    }
}

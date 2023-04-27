using Jadeed.Domain.Enums;

namespace Jadeed.Domain.Commons
{
    public abstract class Auditable
    {
        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public ModelState State { get; set; }
    }
}

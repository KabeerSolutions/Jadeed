using Jadeed.Domain.Commons;

namespace Jadeed.Domain.Entities.Management
{
    public class Room : Auditable
    {
        public string Name { get; set; }
        public long BranchId { get; set; }
        public Branch Branch { get; set; }
        public int Capacity { get; set; }

        // Adding EF Core Relationship
        public ICollection<Group> Groups { get; set; }
    }
}

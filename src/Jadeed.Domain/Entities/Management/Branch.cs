using Jadeed.Domain.Commons;

namespace Jadeed.Domain.Entities.Management
{
    public class Branch : Auditable
    {
        public string Name { get; set; }
        public int NumberOfRooms { get; set; }

    }
}

using Jadeed.Domain.Commons;
using Jadeed.Domain.Entities.Users;

namespace Jadeed.Domain.Entities.Education
{
    public class UserGroup : Auditable
    {
        public long UserId { get; set; }
        public User User { get; set; }

        public long GroupId { get; set; }
        public Group Group { get; set; }
    }
}

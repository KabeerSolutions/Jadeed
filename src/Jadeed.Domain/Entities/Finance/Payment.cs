using Jadeed.Domain.Commons;
using Jadeed.Domain.Entities.Education;
using Jadeed.Domain.Entities.Users;
using System.ComponentModel.DataAnnotations;

namespace Jadeed.Domain.Entities.Finance
{
    public class Payment : Auditable
    {
        public long UserId { get; set; }
        public User User { get; set; }

        public long UserGroupId { get; set; }
        public UserGroup UserGroup { get; set; }

        public decimal Amount { get; set; }
        public int PaidLessonCount { get; set; }

        [StringLength(maximumLength:350)]
        public string Description { get; set; } = string.Empty;
   }
}

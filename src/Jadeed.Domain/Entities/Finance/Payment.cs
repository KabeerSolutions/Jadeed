using Jadeed.Domain.Commons;
using Jadeed.Domain.Entities.Users;
using System.ComponentModel.DataAnnotations;

namespace Jadeed.Domain.Entities.Finance
{
    public class Payment : Auditable
    {
        public long UserId { get; set; }
        public User User { get; set; }

        public long GroupId { get; set; }
        public Group Group { get; set; }

        public decimal Amount { get; set; }
        public int PaidLessonCount { get; set; }
        public DateTime PaidUntil { get; set; }

        [StringLength(maximumLength:350)]
        public string Description { get; set; } = string.Empty;


    }
}

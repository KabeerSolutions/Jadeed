using Jadeed.Domain.Commons;
using System.ComponentModel.DataAnnotations;

namespace Jadeed.Domain.Entities.Users
{
    public class TeacherDetail : Auditable
    {
        public long UserId { get; set; }
        public User User { get; set; }

        [Range(0, 40)]
        public int Experience { get; set; }
        public decimal Salary { get; set; }
        [StringLength(50, MinimumLength = 5)]
        public string Speciality { get; set; }
        
        [StringLength(350)]
        public string Description { get; set; }

        // EF Core conventions to include relations
        public ICollection<Group> Groups { get; set; }
    }
}

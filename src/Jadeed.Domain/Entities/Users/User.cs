using Jadeed.Domain.Commons;
using Jadeed.Domain.Entities.Finance;
using Jadeed.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace Jadeed.Domain.Entities.Users
{
    public class User : Auditable
    {
        [StringLength(50, MinimumLength = 3)]
        public string FirstName { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string LastName { get; set; }

        public DateTime? DateOfBirth { get; set; }
        public string Password { get; set; }

        [StringLength(50, MinimumLength = 7)]
        public string PhoneNumber1 { get; set; }
        
        [StringLength(50, MinimumLength = 7)]
        public string PhoneNumber2 { get; set; }

        public UserRole Role { get; set; }
        public Gender Gender { get; set; }

        // EF Core conventions to include relations
        public ICollection<TeacherDetail> Teachers { get; set; }
        public ICollection<Payment> Payments { get; set; }
        public ICollection<StudentAttendence> Attendences { get; set; }
    }
}

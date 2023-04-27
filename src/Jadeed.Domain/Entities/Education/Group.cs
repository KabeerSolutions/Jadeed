using Jadeed.Domain.Commons;
using Jadeed.Domain.Entities.Education;
using Jadeed.Domain.Entities.Management;
using Jadeed.Domain.Entities.Users;

namespace Jadeed.Domain.Entities
{
    public class Group : Auditable
    {
        public long CourseId { get; set; }
        public Course Course { get; set; }
        public long TeacherDetailId { get; set; }
        public TeacherDetail teacherDetail { get; set; }
        public long RoomId { get; set; }
        public Room Room { get; set; }
        public DateTime StartingAt { get; set; }
        public DateTime StartDate { get; set;}

        // Adding EF core relationship
        public ICollection<LessonDay> LessonDays { get; set; }
        public ICollection<UserGroup> UserGroups { get; set; }
    }
}

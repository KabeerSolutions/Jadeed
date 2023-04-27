using Jadeed.Domain.Commons;
using Jadeed.Domain.Entities.Users;
using Jadeed.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace Jadeed.Domain.Entities
{
    public class StudentAttendence : Auditable
    {
        public long LessonDayId { get; set; }
        public LessonDay LessonDay { get; set; }
        public long StudentId { get; set; }
        public User Student { get; set; }

        [MaxLength(150)]
        public string Description { get; set; }
        public StudentAttendenceType StudentAttendenceType { get; set; }
    }
}

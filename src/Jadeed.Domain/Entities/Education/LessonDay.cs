using Jadeed.Domain.Commons;
using Jadeed.Domain.Entities.Users;
using Jadeed.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace Jadeed.Domain.Entities
{
    public class LessonDay : Auditable
    {
        public long GroupId { get; set; }
        public Group Group { get; set; }

        [Range(1,24)]
        public DateTime? Date { get; set; }

        [StringLength(350)]
        public string Description { get; set; }
        public LessonDayProgressType ProgressType { get; set; }
    }
}

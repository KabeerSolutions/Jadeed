using Jadeed.Domain.Commons;
using System.ComponentModel.DataAnnotations;

namespace Jadeed.Domain.Entities.Education
{
    public class Course : Auditable
    {
        [StringLength(100, MinimumLength = 2)]
        public string Name { get; set; }

        [StringLength(350, MinimumLength = 2)]
        public string Description { get; set; }
        public decimal TotalPaymentPerMonth { get; set; }
        
        [Range(1, 7)]
        public int LessonsCountPerWeek { get; set; }
        
        [Range(1, 24)]
        public double DurationInHours { get; set; }

        // ef core relation conventions
        public ICollection<Group> Groups { get; set; }
    }
}

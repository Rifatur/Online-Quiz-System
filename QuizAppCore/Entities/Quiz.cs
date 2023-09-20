using QuizAppCore.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace QuizAppCore.Entities
{
    public class Quiz : AuditableBaseEntity
    {
        [Key]
        public int QuizId { get; set; }
        public string Title { get; set; }
        public List<QuizQuestion> Questions { get; set; }
        public DateTime StartTime { get; set; }
        public int DurationMinutes { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }

    }
}

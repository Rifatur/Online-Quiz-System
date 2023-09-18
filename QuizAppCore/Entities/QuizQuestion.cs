using QuizAppCore.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace QuizAppCore.Entities
{
    public class QuizQuestion : AuditableBaseEntity
    {
        [Key]
        public int QuestionId { get; set; }
        public string QuestionText { get; set; }
        public List<QuizOption> QuizOptions { get; set; }
        public int CorrectOptionId { get; set; }
        public int QuizId { get; set; }
        public Quiz Quiz { get; set; }

    }
}

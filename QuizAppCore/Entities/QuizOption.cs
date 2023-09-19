using QuizAppCore.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace QuizAppCore.Entities
{
    public class QuizOption : AuditableBaseEntity
    {
        [Key]
        public int OptionId { get; set; }
        public string Text { get; set; }
        public bool IsCorrect { get; set; }
        public int QuestionId { get; set; }
        public QuizQuestion Question { get; set; }
    }
}

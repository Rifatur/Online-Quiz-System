using QuizAppCore.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace QuizAppCore.Entities
{
    public class Subject : AuditableBaseEntity
    {
        [Key]
        public int SubjectId { get; set; }
        public string? Name { get; set; }
        public string? BanglaName { get; set; }
        public List<Quiz>? Quizs { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace QuizAppCore.Entities
{
    public class QuizOption
    {
        [Key]
        public int OptionId { get; set; }
        public string Text { get; set; }
        public int QuestionId { get; set; }
        public QuizQuestion Question { get; set; }
    }
}

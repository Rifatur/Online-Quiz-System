using QuizAppCore.Entities.Common;

namespace QuizAppCore.Entities
{
    public class QuizScore : AuditableBaseEntity
    {
        public int Id { get; set; }
        public int QuizId { get; set; }
        public Quiz Quiz { get; set; }
        public int UserId { get; set; }
        //public User User { get; set; }
        public int Points { get; set; }
        public DateTime CompletionTime { get; set; }
    }
}

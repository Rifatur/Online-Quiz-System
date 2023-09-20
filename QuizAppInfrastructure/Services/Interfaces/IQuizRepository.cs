using QuizAppCore.Entities;

namespace QuizAppDataAccess.Services.Interfaces
{
    public interface IQuizRepository : IRepository<Quiz>
    {
        Task<Quiz> GetQuizById(int quizId);
        QuizQuestion GetQuestionById(int questionId);
        void StartQuiz(int quizId, int userId);
        void SubmitAnswer(int questionId, int answerId, int userId);
        void EndQuiz(int quizId, int userId);
        List<QuizScore> GetLeaderboard();
    }
}

using Microsoft.EntityFrameworkCore;
using QuizAppCore.Entities;
using QuizAppDataAccess.Context;
using QuizAppDataAccess.Services.Interfaces;

namespace QuizAppDataAccess.Services.Implemantations
{
    public class QuizRepository : Repository<Quiz>, IQuizRepository
    {
        public readonly ApplicationDbContext _context;
        public QuizRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public void EndQuiz(int quizId, int userId)
        {
            throw new NotImplementedException();
        }

        public List<QuizScore> GetLeaderboard()
        {
            throw new NotImplementedException();
        }

        public QuizQuestion GetQuestionById(int questionId)
        {
            throw new NotImplementedException();
        }

        public async Task<Quiz> GetQuizById(int quizId)
        {
            return _context.Quizzes.Include(q => q.Questions).FirstOrDefault(q => q.QuizId == quizId);
        }


        public void StartQuiz(int quizId, int userId)
        {
            throw new NotImplementedException();
        }

        public void SubmitAnswer(int questionId, int answerId, int userId)
        {
            throw new NotImplementedException();
        }
    }
}

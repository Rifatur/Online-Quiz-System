using Microsoft.EntityFrameworkCore;
using QuizAppCore.Entities;

namespace QuizAppDataAccess.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Quiz> Quizzes { get; set; }
        public virtual DbSet<QuizQuestion> QuizQuestions { get; set; }
        public virtual DbSet<QuizOption> QuizOptions { get; set; }

    }
}

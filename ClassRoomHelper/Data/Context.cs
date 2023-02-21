using Microsoft.EntityFrameworkCore;
using ClassRoomHelper.Models;
namespace ClassRoomHelper.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options){

        }
        public DbSet<Answers> Answers { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<AssignmentDetails> AssignmentsDetails { get; set; }
        public DbSet<FlashCard> FlashCards { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Users> User { get; set; }
    }
}

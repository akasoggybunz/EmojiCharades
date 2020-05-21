using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EmojiCharades.Data
{
    /// <summary>
    /// Data model for sqllite for web app
    /// </summary>
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
            
        }

        public DbSet<Questions> Questions { get; set; }
        public DbSet<Answers> Answers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=charades.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Questions>().ToTable("Questions");
            modelBuilder.Entity<Answers>().ToTable("Answers");
        }
    }

    /// <summary>
    /// Questions to ask the players
    /// </summary>
    public class Questions
    {
        // pk
        public int id { get; set; }

        // The Question
        public string Question { get; set; }

        // tags for this question
        public string Tags { get; set; }

        // Question PG ?
        public bool NSFW { get; set; }

    }

    /// <summary>
    /// Answers
    /// </summary>
    public class Answers
    {
        /// <summary>
        /// PK
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// User's name
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Created Date
        /// </summary>
        public DateTime created { get; set; }

        /// <summary>
        /// The Questions PK
        /// </summary>
        public int QuestionId { get; set; }

        /// <summary>
        /// Answer given by user
        /// </summary>
        public string AnswerGiven { get; set; }

        /// <summary>
        /// Upvotes from audience. 
        /// </summary>
        public int Upvotes { get; set; }
    }
}

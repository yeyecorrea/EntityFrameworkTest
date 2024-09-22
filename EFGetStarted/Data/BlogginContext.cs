using EFGetStarted.Models;
using Microsoft.EntityFrameworkCore;

namespace EFGetStarted.Data
{
    public class BlogginContext : DbContext
    {
        public DbSet<Blog> blogs { get; set; }
        public DbSet<Post> posts { get; set; }

        public string DbPath { get; }

        public BlogginContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "blogging.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}

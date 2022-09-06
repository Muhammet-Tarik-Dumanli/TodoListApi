using Microsoft.EntityFrameworkCore;

namespace TodoListApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<TodoItem> TodoItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoItem>().HasData(
                new TodoItem() { Id = 1, IsDone = false, Title = "Go shopping" },
                new TodoItem() { Id = 2, IsDone = false, Title = "Do your homework" },
                new TodoItem() { Id = 3, IsDone = true, Title = "Wash your car" },
                new TodoItem() { Id = 4, IsDone = true, Title = "Watch Netflix" }
                );
        }
    }
}

using Microsoft.EntityFrameworkCore;

namespace todoWebApi.Models
{
    public class TodoContext : DbContext
	{
		public TodoContext(DbContextOptions<TodoContext> options)
			: base(options)
		{
		}

		public DbSet<TodoItem> TodoItems { get; set; }

	}
}
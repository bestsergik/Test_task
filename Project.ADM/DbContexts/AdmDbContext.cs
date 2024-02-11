
namespace Project.ADM.DbContexts
{
    /// <summary>
    /// Контекст базы данных для ADM проекта.
    /// Определяет набор сущностей, которые включены в модель данных.
    /// </summary>
    public class AdmDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<ListCategory> ListCategories { get; set; }
        public DbSet<TaskUserCache> TaskUserCaches { get; set; }

        public AdmDbContext(DbContextOptions<AdmDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Настройка схемы базы данных с использованием Fluent API
            modelBuilder.Entity<User>()
                .ToTable("Users")
                .HasKey(u => u.ID);

            modelBuilder.Entity<ListCategory>()
                .ToTable("ListCategories")
                .HasKey(lc => lc.ID);

            modelBuilder.Entity<TaskUserCache>()
                .ToTable("TaskUserCaches")
                .HasKey(tuc => new { tuc.TaskID, tuc.UserID, tuc.TaskListCategoryID });

            // Определение отношений между TaskUserCache и User
            modelBuilder.Entity<TaskUserCache>()
                .HasOne(tuc => tuc.User)
                .WithMany(u => u.TaskUserCaches)
                .HasForeignKey(tuc => tuc.UserID);

            // Определение отношений между TaskUserCache и ListCategory
            modelBuilder.Entity<TaskUserCache>()
                .HasOne(tuc => tuc.ListCategory)
                .WithMany(lc => lc.TaskUserCaches)
                .HasForeignKey(tuc => tuc.TaskListCategoryID);
        }
    }
}

namespace Project.WORK.DbContexts
{
    /// <summary>
    /// Контекст базы данных для проекта WORK.
    /// Содержит наборы сущностей, используемых для взаимодействия с базой данных.
    /// </summary>
    public class WorkDbContext : DbContext
    {
        // Определение наборов сущностей в контексте
        public DbSet<WorkTask> Tasks { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<TaskUserCache> TaskUserCaches { get; set; }
        public DbSet<ListCategory> ListCategories { get; set; }
        public DbSet<Employment> Employments { get; set; }
        public DbSet<TaskResponsibleUser> TaskResponsibleUsers { get; set; }

        public WorkDbContext(DbContextOptions<WorkDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

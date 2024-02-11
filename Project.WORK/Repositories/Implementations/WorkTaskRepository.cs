using Project.WORK.Repositories.Interfaces;


namespace Project.WORK.Repositories.Implementations
{
    /// <summary>
    /// Реализация репозитория для управления задачами.
    /// Предоставляет методы для доступа и управления данными задач.
    /// </summary>
    public class WorkTaskRepository : IWorkTaskRepository
    {
        private readonly WorkDbContext _context;

        public WorkTaskRepository(WorkDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Получает задачу по её идентификатору.
        /// </summary>
        public async Task<WorkTask> GetByIdAsync(int id)
        {
            return await _context.Tasks.FindAsync(id);
        }

        /// <summary>
        /// Получает список всех задач.
        /// </summary>
        public async Task<IEnumerable<WorkTask>> GetAllAsync()
        {
            return await _context.Tasks.ToListAsync();
        }

        /// <summary>
        /// Добавляет новую задачу в базу данных.
        /// </summary>
        public async Task AddAsync(WorkTask workTask)
        {
            await _context.Tasks.AddAsync(workTask);
            await _context.SaveChangesAsync();
        }
    }
}

using Project.WORK.Repositories.Interfaces;


namespace Project.WORK.Repositories.Implementations
{
    /// <summary>
    /// Реализация репозитория для работы с кэшем задач пользователя.
    /// Обеспечивает доступ к данным кэша задач и их управление.
    /// </summary>
    public class TaskUserCacheRepository : ITaskUserCacheRepository
    {
        private readonly WorkDbContext _context;

        public TaskUserCacheRepository(WorkDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Получает все записи из кэша задач.
        /// </summary>
        public async Task<IEnumerable<TaskUserCache>> GetAllAsync()
        {
            return await _context.TaskUserCaches.ToListAsync();
        }

        /// <summary>
        /// Добавляет новую запись в кэш задач.
        /// </summary>
        public async Task AddAsync(TaskUserCache taskUserCache)
        {
            await _context.TaskUserCaches.AddAsync(taskUserCache);
            await _context.SaveChangesAsync();
        }
    }
}

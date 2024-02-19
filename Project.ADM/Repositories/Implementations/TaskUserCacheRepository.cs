using Project.ADM.Repositories.Interfaces;

namespace Project.ADM.Repositories.Implementations
{
    /// <summary>
    /// Репозиторий для работы с кэшем задач пользователя.
    /// Предоставляет методы для доступа и управления кэшем задач в базе данных.
    /// </summary>
    public class TaskUserCacheRepository : ITaskUserCacheRepository
    {
        private readonly AdmDbContext _context;

        public TaskUserCacheRepository(AdmDbContext context)
        {
            _context = context; // Инициализация контекста базы данных
        }

        /// <summary>
        /// Получает все элементы кэша задач.
        /// </summary>
        /// <returns>Коллекция всех элементов кэша задач.</returns>
        public async Task<IEnumerable<TaskUserCache>> GetAllAsync()
        {
            return await _context.TaskUserCaches.ToListAsync();
        }

        /// <summary>
        /// Добавляет новый элемент в кэш задач пользователя.
        /// </summary>
        /// <param name="taskUserCache">Элемент кэша задач для добавления.</param>
        public async Task AddAsync(TaskUserCache taskUserCache)
        {
            await _context.TaskUserCaches.AddAsync(taskUserCache);
            await _context.SaveChangesAsync(); // Сохранение изменений в базе данных
        }

        public async Task<IEnumerable<TaskUserCache>> GetByUserAndCategoryIdsAsync(int userId, IEnumerable<int> categoryIds)
        {
            return await _context.TaskUserCaches
                .Where(tuc => tuc.UserID == userId && categoryIds.Contains(tuc.TaskListCategoryID))
                .ToListAsync();
        }

    }
}

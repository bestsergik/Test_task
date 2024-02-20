namespace Project.WORK.Repositories.Interfaces
{
    /// <summary>
    /// Интерфейс для репозитория кэша задач, обеспечивающий доступ к кэшированным данным задач и пользователей.
    /// </summary>
    public interface ITaskUserCacheRepository
    {
        /// <summary>
        /// Получает все записи кэша задач.
        /// </summary>
        Task<IEnumerable<TaskUserCache>> GetAllAsync();

        /// <summary>
        /// Добавляет новую запись в кэш задач.
        /// </summary>
        Task AddAsync(TaskUserCache taskUserCache);
    }
}

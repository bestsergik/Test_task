namespace Project.ADM.Services.Interfaces
{
    /// <summary>
    /// Интерфейс сервиса для управления кэшем задач пользователя.
    /// </summary>
    public interface ITaskUserCacheService
    {
        /// <summary>
        /// Получает все записи кэша задач.
        /// </summary>
        Task<IEnumerable<TaskUserCache>> GetAllTaskUserCachesAsync();

        /// <summary>
        /// Добавляет новую запись в кэш задач.
        /// </summary>
        Task CreateTaskUserCacheAsync(TaskUserCache taskUserCache);
    }
}

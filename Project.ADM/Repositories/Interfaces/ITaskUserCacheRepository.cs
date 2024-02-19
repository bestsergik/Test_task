namespace Project.ADM.Repositories.Interfaces
{
    /// <summary>
    /// Определяет контракт репозитория для работы с кэшем задач пользователя.
    /// </summary>
    public interface ITaskUserCacheRepository
    {
        /// <summary>
        /// Получает все элементы кэша задач.
        /// </summary>
        /// <returns>Коллекция всех элементов кэша задач.</returns>
        Task<IEnumerable<TaskUserCache>> GetAllAsync();

        /// <summary>
        /// Добавляет новый элемент в кэш задач пользователя.
        /// </summary>
        /// <param name="taskUserCache">Элемент кэша задач для добавления.</param>
        Task AddAsync(TaskUserCache taskUserCache);
    }
}

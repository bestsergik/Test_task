namespace Project.WORK.Repositories.Interfaces
{
    /// <summary>
    /// Интерфейс для репозитория задач, обеспечивающий доступ к данным о задачах.
    /// </summary>
    public interface IWorkTaskRepository
    {
        /// <summary>
        /// Получает задачу по идентификатору.
        /// </summary>
        Task<WorkTask> GetByIdAsync(int id);

        /// <summary>
        /// Получает все задачи.
        /// </summary>
        Task<IEnumerable<WorkTask>> GetAllAsync();

        /// <summary>
        /// Добавляет новую задачу в базу данных.
        /// </summary>
        Task AddAsync(WorkTask workTask);
    }
}

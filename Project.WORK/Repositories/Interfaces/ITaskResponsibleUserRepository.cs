namespace Project.WORK.Repositories.Interfaces
{
    /// <summary>
    /// Интерфейс для репозитория ответственных за выполнение задач, обеспечивающий доступ к данным о задачах и их ответственных.
    /// </summary>
    public interface ITaskResponsibleUserRepository
    {
        /// <summary>
        /// Получает всех ответственных пользователей за задачи.
        /// </summary>
        Task<IEnumerable<TaskResponsibleUser>> GetAllAsync();

        /// <summary>
        /// Добавляет запись о новом ответственном за задачу в базу данных.
        /// </summary>
        Task AddAsync(TaskResponsibleUser taskResponsibleUser);
    }
}

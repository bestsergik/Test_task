namespace Project.WORK.Repositories.Interfaces
{
    /// <summary>
    /// Интерфейс для репозитория трудоустройства, обеспечивающий доступ к данным о трудоустройстве пользователей.
    /// </summary>
    public interface IEmploymentRepository
    {
        /// <summary>
        /// Получает все записи о трудоустройстве.
        /// </summary>
        Task<IEnumerable<Employment>> GetAllAsync();

        /// <summary>
        /// Добавляет новую запись о трудоустройстве в базу данных.
        /// </summary>
        Task AddAsync(Employment employment);
    }
}

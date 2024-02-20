namespace Project.WORK.Repositories.Interfaces
{
    /// <summary>
    /// Интерфейс для репозитория пользователей, обеспечивающий доступ к данным о пользователях.
    /// </summary>
    public interface IUserRepository
    {
        /// <summary>
        /// Получает пользователя по идентификатору.
        /// </summary>
        Task<User> GetByIdAsync(int id);

        /// <summary>
        /// Получает всех пользователей.
        /// </summary>
        Task<IEnumerable<User>> GetAllAsync();

        /// <summary>
        /// Добавляет нового пользователя в базу данных.
        /// </summary>
        Task AddAsync(User user);
    }
}

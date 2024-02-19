namespace Project.ADM.Repositories.Interfaces
{
    /// <summary>
    /// Определяет контракт репозитория для работы с пользователями.
    /// </summary>
    public interface IUserRepository
    {
        /// <summary>
        /// Получает пользователя по его идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор пользователя.</param>
        /// <returns>Пользователь, если найден; иначе null.</returns>
        Task<User> GetByIdAsync(int id);

        /// <summary>
        /// Получает всех пользователей.
        /// </summary>
        /// <returns>Коллекция всех пользователей.</returns>
        Task<IEnumerable<User>> GetAllAsync();

        /// <summary>
        /// Добавляет нового пользователя в базу данных.
        /// </summary>
        /// <param name="user">Пользователь для добавления.</param>
        Task AddAsync(User user);
    }
}

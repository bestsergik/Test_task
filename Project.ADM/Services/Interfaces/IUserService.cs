using Project.ADM.Models;

namespace Project.ADM.Services.Interfaces
{
    /// <summary>
    /// Интерфейс сервиса для управления пользователями.
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Получает пользователя по идентификатору.
        /// </summary>
        Task<User> GetUserByIdAsync(int id);

        /// <summary>
        /// Получает всех пользователей.
        /// </summary>
        Task<IEnumerable<User>> GetAllUsersAsync();

        /// <summary>
        /// Создает нового пользователя.
        /// </summary>
        Task CreateUserAsync(User user);
    }
}

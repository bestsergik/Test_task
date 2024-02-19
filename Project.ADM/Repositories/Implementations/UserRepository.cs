using Project.ADM.Repositories.Interfaces;

namespace Project.ADM.Repositories.Implementations
{
    /// <summary>
    /// Репозиторий для работы с пользователями.
    /// Предоставляет методы для доступа и управления пользователями в базе данных.
    /// </summary>
    public class UserRepository : IUserRepository
    {
        private readonly AdmDbContext _context;

        public UserRepository(AdmDbContext context)
        {
            _context = context; // Инициализация контекста базы данных
        }

        /// <summary>
        /// Получает пользователя по его идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор пользователя.</param>
        /// <returns>Пользователь, если найден; иначе null.</returns>
        public async Task<User> GetByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        /// <summary>
        /// Получает всех пользователей.
        /// </summary>
        /// <returns>Коллекция всех пользователей.</returns>
        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }

        /// <summary>
        /// Добавляет нового пользователя в базу данных.
        /// </summary>
        /// <param name="user">Пользователь для добавления.</param>
        public async Task AddAsync(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync(); // Сохранение изменений в базе данных
        }
    }
}


using Project.WORK.Repositories.Interfaces;

namespace Project.WORK.Repositories.Implementations
{
    /// <summary>
    /// Реализация репозитория для управления пользователями.
    /// Предоставляет методы для доступа и управления данными пользователей.
    /// </summary>
    public class UserRepository : IUserRepository
    {
        private readonly WorkDbContext _context;

        public UserRepository(WorkDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Получает пользователя по его идентификатору.
        /// </summary>
        public async Task<User> GetByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        /// <summary>
        /// Получает список всех пользователей.
        /// </summary>
        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }

        /// <summary>
        /// Добавляет нового пользователя в базу данных.
        /// </summary>
        public async Task AddAsync(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }
    }
}

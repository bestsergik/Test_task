using Project.WORK.Repositories.Interfaces;

namespace Project.WORK.Repositories.Implementations
{
    /// <summary>
    /// Реализация репозитория для работы с данными о трудоустройстве пользователей.
    /// </summary>
    public class EmploymentRepository : IEmploymentRepository
    {
        private readonly WorkDbContext _context;

        public EmploymentRepository(WorkDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Получает все записи о трудоустройстве.
        /// </summary>
        public async Task<IEnumerable<Employment>> GetAllAsync()
        {
            return await _context.Employments.ToListAsync();
        }

        /// <summary>
        /// Добавляет информацию о трудоустройстве пользователя в базу данных.
        /// </summary>
        public async Task AddAsync(Employment employment)
        {
            await _context.Employments.AddAsync(employment);
            await _context.SaveChangesAsync();
        }
    }
}

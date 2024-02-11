using Project.WORK.Repositories.Interfaces;


namespace Project.WORK.Repositories.Implementations
{
    /// <summary>
    /// Реализация репозитория для работы с категориями задач.
    /// </summary>
    public class ListCategoryRepository : IListCategoryRepository
    {
        private readonly WorkDbContext _context;

        public ListCategoryRepository(WorkDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Получает категорию по идентификатору.
        /// </summary>
        public async Task<ListCategory> GetByIdAsync(byte id)
        {
            return await _context.ListCategories.FindAsync(id);
        }

        /// <summary>
        /// Получает список всех категорий.
        /// </summary>
        public async Task<IEnumerable<ListCategory>> GetAllAsync()
        {
            return await _context.ListCategories.ToListAsync();
        }

        /// <summary>
        /// Добавляет новую категорию в базу данных.
        /// </summary>
        public async Task AddAsync(ListCategory listCategory)
        {
            await _context.ListCategories.AddAsync(listCategory);
            await _context.SaveChangesAsync();
        }
    }
}


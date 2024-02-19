using Project.ADM.Repositories.Interfaces;

namespace Project.ADM.Repositories.Implementations
{
    /// <summary>
    /// Репозиторий для работы с категориями списка задач.
    /// Предоставляет методы для доступа и управления категориями в базе данных.
    /// </summary>
    public class ListCategoryRepository : IListCategoryRepository
    {
        private readonly AdmDbContext _context;

        public ListCategoryRepository(AdmDbContext context)
        {
            _context = context; // Инициализация контекста базы данных
        }

        /// <summary>
        /// Получает категорию по её идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор категории.</param>
        /// <returns>Категория, если найдена; иначе null.</returns>
        public async Task<ListCategory> GetByIdAsync(byte id)
        {
            return await _context.ListCategories.FindAsync(id);
        }

        /// <summary>
        /// Получает все категории.
        /// </summary>
        /// <returns>Коллекция всех категорий.</returns>
        public async Task<IEnumerable<ListCategory>> GetAllAsync()
        {
            return await _context.ListCategories.ToListAsync();
        }

        /// <summary>
        /// Добавляет новую категорию в базу данных.
        /// </summary>
        /// <param name="listCategory">Категория для добавления.</param>
        public async Task AddAsync(ListCategory listCategory)
        {
            await _context.ListCategories.AddAsync(listCategory);
            await _context.SaveChangesAsync(); // Сохранение изменений в базе данных
        }
    }
}

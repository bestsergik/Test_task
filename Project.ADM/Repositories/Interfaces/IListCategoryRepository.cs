namespace Project.ADM.Repositories.Interfaces
{
    /// <summary>
    /// Определяет контракт репозитория для работы с категориями списка задач.
    /// </summary>
    public interface IListCategoryRepository
    {
        /// <summary>
        /// Получает категорию по её идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор категории.</param>
        /// <returns>Категория, если найдена; иначе null.</returns>
        Task<ListCategory> GetByIdAsync(byte id);

        /// <summary>
        /// Получает все категории.
        /// </summary>
        /// <returns>Коллекция всех категорий.</returns>
        Task<IEnumerable<ListCategory>> GetAllAsync();

        /// <summary>
        /// Добавляет новую категорию в базу данных.
        /// </summary>
        /// <param name="listCategory">Категория для добавления.</param>
        Task AddAsync(ListCategory listCategory);
    }
}

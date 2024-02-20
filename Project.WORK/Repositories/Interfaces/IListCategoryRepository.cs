namespace Project.WORK.Repositories.Interfaces
{
    /// <summary>
    /// Интерфейс для репозитория категорий задач, обеспечивающий доступ к данным о категориях.
    /// </summary>
    public interface IListCategoryRepository
    {
        /// <summary>
        /// Получает категорию по её идентификатору.
        /// </summary>
        Task<ListCategory> GetByIdAsync(byte id);

        /// <summary>
        /// Получает все категории.
        /// </summary>
        Task<IEnumerable<ListCategory>> GetAllAsync();

        /// <summary>
        /// Добавляет новую категорию в базу данных.
        /// </summary>
        Task AddAsync(ListCategory listCategory);
    }
}

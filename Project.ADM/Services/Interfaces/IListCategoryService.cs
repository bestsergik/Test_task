namespace Project.ADM.Services.Interfaces
{
    /// <summary>
    /// Интерфейс сервиса для управления категориями списка задач.
    /// </summary>
    public interface IListCategoryService
    {
        /// <summary>
        /// Получает категорию по идентификатору.
        /// </summary>
        Task<ListCategory> GetListCategoryByIdAsync(byte id);

        /// <summary>
        /// Получает все категории.
        /// </summary>
        Task<IEnumerable<ListCategory>> GetAllListCategoriesAsync();

        /// <summary>
        /// Создает новую категорию.
        /// </summary>
        Task CreateListCategoryAsync(ListCategory listCategory);
    }
}

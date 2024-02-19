using Project.ADM.Repositories.Interfaces;
using Project.ADM.Services.Interfaces;


namespace Project.ADM.Services.Implementations
{
    /// <summary>
    /// Реализация сервиса для управления категориями списка задач.
    /// </summary>
    public class ListCategoryService : IListCategoryService
    {
        private readonly IListCategoryRepository _listCategoryRepository;


        public ListCategoryService(IListCategoryRepository listCategoryRepository)
        {
            _listCategoryRepository = listCategoryRepository;
        }


        public async Task<ListCategory> GetListCategoryByIdAsync(byte id)
        {
            return await _listCategoryRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<ListCategory>> GetAllListCategoriesAsync()
        {
            return await _listCategoryRepository.GetAllAsync();
        }

        public async Task CreateListCategoryAsync(ListCategory listCategory)
        {
            await _listCategoryRepository.AddAsync(listCategory);
        }

    }
}

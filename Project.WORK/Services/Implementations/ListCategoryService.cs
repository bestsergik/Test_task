using Project.WORK.Repositories.Interfaces;
using Project.WORK.Services.Interfaces;

namespace Project.WORK.Services.Implementations
{
    public class ListCategoryService : IListCategoryService
    {
        private readonly IListCategoryRepository _repository;

        public ListCategoryService(IListCategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<ListCategory> GetByIdAsync(byte id) => await _repository.GetByIdAsync(id);

        public async Task<IEnumerable<ListCategory>> GetAllAsync() => await _repository.GetAllAsync();

        public async Task AddAsync(ListCategory listCategory) => await _repository.AddAsync(listCategory);
    }

}

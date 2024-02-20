namespace Project.WORK.Services.Interfaces
{
    public interface IListCategoryService
    {
        Task<ListCategory> GetByIdAsync(byte id);
        Task<IEnumerable<ListCategory>> GetAllAsync();
        Task AddAsync(ListCategory listCategory);
    }

}

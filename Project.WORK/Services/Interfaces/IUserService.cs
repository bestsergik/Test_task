namespace Project.WORK.Services.Interfaces
{
    public interface IUserService
    {
        Task<User> GetByIdAsync(int id);
        Task<IEnumerable<User>> GetAllAsync();
        Task AddAsync(User user);
    }

}

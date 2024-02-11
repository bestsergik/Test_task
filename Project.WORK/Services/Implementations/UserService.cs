
using Project.WORK.Models;
using Project.WORK.Repositories.Interfaces;
using Project.WORK.Services.Interfaces;

namespace Project.WORK.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<User> GetByIdAsync(int id) => await _repository.GetByIdAsync(id);

        public async Task<IEnumerable<User>> GetAllAsync() => await _repository.GetAllAsync();

        public async Task AddAsync(User user) => await _repository.AddAsync(user);
    }

}

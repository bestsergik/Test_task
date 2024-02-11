using Project.ADM.Models;
using Project.ADM.Repositories.Interfaces;
using Project.ADM.Services.Interfaces;

namespace Project.ADM.Services.Implementations
{
    /// <summary>
    /// Реализация сервиса для управления пользователями.
    /// </summary>
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _userRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await _userRepository.GetAllAsync();
        }

        public async Task CreateUserAsync(User user)
        {
            await _userRepository.AddAsync(user);
        }
    }
}


using Project.ADM.Models;
using Project.ADM.Repositories.Interfaces;
using Project.ADM.Services.Interfaces;

namespace Project.ADM.Services.Implementations
{
    /// <summary>
    /// Реализация сервиса для управления кэшем задач пользователя.
    /// </summary>
    public class TaskUserCacheService : ITaskUserCacheService
    {
        private readonly ITaskUserCacheRepository _taskUserCacheRepository;

        public TaskUserCacheService(ITaskUserCacheRepository taskUserCacheRepository)
        {
            _taskUserCacheRepository = taskUserCacheRepository;
        }

        public async Task<IEnumerable<TaskUserCache>> GetAllTaskUserCachesAsync()
        {
            return await _taskUserCacheRepository.GetAllAsync();
        }

        public async Task CreateTaskUserCacheAsync(TaskUserCache taskUserCache)
        {
            await _taskUserCacheRepository.AddAsync(taskUserCache);
        }
    }
}

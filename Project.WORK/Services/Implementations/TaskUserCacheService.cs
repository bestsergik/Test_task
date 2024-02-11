using Project.WORK.Models;
using Project.WORK.Repositories.Interfaces;
using Project.WORK.Services.Interfaces;


namespace Project.WORK.Services.Implementations
{
    public class TaskUserCacheService : ITaskUserCacheService
    {
        private readonly ITaskUserCacheRepository _repository;

        public TaskUserCacheService(ITaskUserCacheRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<TaskUserCache>> GetAllAsync() => await _repository.GetAllAsync();

        public async Task AddAsync(TaskUserCache taskUserCache) => await _repository.AddAsync(taskUserCache);
    }

}

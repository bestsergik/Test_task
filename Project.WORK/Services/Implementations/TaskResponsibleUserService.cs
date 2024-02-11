using Project.WORK.Models;
using Project.WORK.Repositories.Interfaces;
using Project.WORK.Services.Interfaces;

namespace Project.WORK.Services.Implementations
{
    public class TaskResponsibleUserService : ITaskResponsibleUserService
    {
        private readonly ITaskResponsibleUserRepository _repository;

        public TaskResponsibleUserService(ITaskResponsibleUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<TaskResponsibleUser>> GetAllAsync() => await _repository.GetAllAsync();

        public async Task AddAsync(TaskResponsibleUser taskResponsibleUser) => await _repository.AddAsync(taskResponsibleUser);
    }

}

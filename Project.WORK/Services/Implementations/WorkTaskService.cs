using Project.WORK.Models;
using Project.WORK.Repositories.Interfaces;
using Project.WORK.Services.Interfaces;

namespace Project.WORK.Services.Implementations
{
    public class WorkTaskService : IWorkTaskService
    {
        private readonly IWorkTaskRepository _workTaskRepository;

        public WorkTaskService(IWorkTaskRepository workTaskRepository)
        {
            _workTaskRepository = workTaskRepository;
        }

        public async Task<WorkTask> GetWorkTaskByIdAsync(int id)
        {
            return await _workTaskRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<WorkTask>> GetAllWorkTasksAsync()
        {
            return await _workTaskRepository.GetAllAsync();
        }

        public async Task CreateWorkTaskAsync(WorkTask workTask)
        {
            await _workTaskRepository.AddAsync(workTask);
        }
    }


}

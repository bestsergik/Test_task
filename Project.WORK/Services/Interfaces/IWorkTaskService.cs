namespace Project.WORK.Services.Interfaces
{
    public interface IWorkTaskService
    {
        Task<WorkTask> GetWorkTaskByIdAsync(int id);
        Task<IEnumerable<WorkTask>> GetAllWorkTasksAsync();
        Task CreateWorkTaskAsync(WorkTask workTask);
        // Дополнительные методы по необходимости
    }


}

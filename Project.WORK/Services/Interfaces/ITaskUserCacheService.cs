namespace Project.WORK.Services.Interfaces
{
    public interface ITaskUserCacheService
    {
        Task<IEnumerable<TaskUserCache>> GetAllAsync();
        Task AddAsync(TaskUserCache taskUserCache);
    }

}

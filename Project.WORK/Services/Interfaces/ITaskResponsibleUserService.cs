using Project.WORK.Models;


namespace Project.WORK.Services.Interfaces
{
    public interface ITaskResponsibleUserService
    {
        Task<IEnumerable<TaskResponsibleUser>> GetAllAsync();
        Task AddAsync(TaskResponsibleUser taskResponsibleUser);
    }

}

using Project.WORK.Models;


namespace Project.WORK.Repositories.Interfaces
{
    public interface IEmploymentRepository
    {
        Task<IEnumerable<Employment>> GetAllAsync();
        Task AddAsync(Employment employment);
    }

}

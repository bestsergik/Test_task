namespace Project.WORK.Services.Interfaces
{
    public interface IEmploymentService
    {
        Task<IEnumerable<Employment>> GetAllAsync();
        Task AddAsync(Employment employment);
    }

}

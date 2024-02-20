using Project.WORK.Repositories.Interfaces;
using Project.WORK.Services.Interfaces;


namespace Project.WORK.Services.Implementations
{
    public class EmploymentService : IEmploymentService
    {
        private readonly IEmploymentRepository _repository;

        public EmploymentService(IEmploymentRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Employment>> GetAllAsync() => await _repository.GetAllAsync();

        public async Task AddAsync(Employment employment) => await _repository.AddAsync(employment);
    }

}

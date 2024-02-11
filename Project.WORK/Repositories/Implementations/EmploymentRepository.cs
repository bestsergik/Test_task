using Microsoft.EntityFrameworkCore;
using Project.WORK.DbContexts;
using Project.WORK.Models;
using Project.WORK.Repositories.Interfaces;

namespace Project.WORK.Repositories.Implementations
{
    public class EmploymentRepository : IEmploymentRepository
    {
        private readonly WorkDbContext _context;

        public EmploymentRepository(WorkDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Employment>> GetAllAsync()
        {
            return await _context.Employments.ToListAsync();
        }

        public async Task AddAsync(Employment employment)
        {
            await _context.Employments.AddAsync(employment);
            await _context.SaveChangesAsync();
        }
    }

}

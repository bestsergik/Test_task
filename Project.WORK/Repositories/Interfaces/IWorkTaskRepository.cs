using Project.WORK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.WORK.Repositories.Interfaces
{
    public interface IWorkTaskRepository
    {
        Task<WorkTask> GetByIdAsync(int id);
        Task<IEnumerable<WorkTask>> GetAllAsync();
        Task AddAsync(WorkTask workTask);
    }

}

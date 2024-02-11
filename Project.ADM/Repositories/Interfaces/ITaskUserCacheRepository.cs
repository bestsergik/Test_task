using Project.ADM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ADM.Repositories.Interfaces
{
    public interface ITaskUserCacheRepository
    {
        Task<IEnumerable<TaskUserCache>> GetAllAsync();
        Task AddAsync(TaskUserCache taskUserCache);
    }
}

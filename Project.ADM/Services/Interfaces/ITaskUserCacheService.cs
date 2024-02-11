using Project.ADM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ADM.Services.Interfaces
{
    public interface ITaskUserCacheService
    {
        Task<IEnumerable<TaskUserCache>> GetAllTaskUserCachesAsync();
        Task CreateTaskUserCacheAsync(TaskUserCache taskUserCache);
    }

}

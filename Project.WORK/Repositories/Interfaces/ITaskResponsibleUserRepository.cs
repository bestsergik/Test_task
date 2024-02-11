using Project.WORK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.WORK.Repositories.Interfaces
{
    public interface ITaskResponsibleUserRepository
    {
        Task<IEnumerable<TaskResponsibleUser>> GetAllAsync();
        Task AddAsync(TaskResponsibleUser taskResponsibleUser);
    }

}

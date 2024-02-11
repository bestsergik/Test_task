﻿using Project.ADM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ADM.Repositories.Interfaces
{
    public interface IListCategoryRepository
    {
        Task<ListCategory> GetByIdAsync(byte id);
        Task<IEnumerable<ListCategory>> GetAllAsync();
        Task AddAsync(ListCategory listCategory);
    }
}

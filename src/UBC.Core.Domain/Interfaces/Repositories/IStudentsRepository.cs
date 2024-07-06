﻿using UBC.Core.Domain.Entities;
using UBC.Core.Domain.Filters;

namespace UBC.Core.Domain.Interfaces.Repositories
{
    public interface IStudentsRepository : IRepositoryBase<StudentEntity>
    {
        Task<int> CountByFilterAsync(StudentFilter filter);

        Task<List<StudentEntity>> GetListByFilterAsync(StudentFilter filter);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocketDataAccessLayer.IRepositories
{
    public interface IUnitOfWork
    {
        IBaseRepository<T> GetRepository<T>() where T : class;

        int Save();

        Task<int> SaveAsync();
    }
}
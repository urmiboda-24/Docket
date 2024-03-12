using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocketDataAccessLayer.Data;
using DocketDataAccessLayer.IRepositories;

namespace DocketDataAccessLayer.Repositories
{
    public class UnitOfWork
    {
        private readonly AppDbContext _dbContext;

        public IBaseRepository<T> GetRepository<T>() where T : class
        {
            return new BaseRepository<T>(_dbContext);
        }

        public int Save() => _dbContext.SaveChanges();

        public Task<int> SaveAsync() => _dbContext.SaveChangesAsync();
    }
}
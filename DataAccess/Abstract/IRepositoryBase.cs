using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IRepositoryBase<T> where T : IEntity
    {
        Task<int> Add(T item);
        Task<int> Delete(T item);
        Task<int> Update(T item);
        Task<List<T>> GetAll();
        Task<T> Get(int id);

    }
}

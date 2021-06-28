using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IService<T> 
    {
        Task<bool> Add(T item);
        Task<bool> Delete(T item);
        Task<bool> Update(T item);
        Task<List<T>> GetAll();
        Task<T> Get(int itemid);
    }
}

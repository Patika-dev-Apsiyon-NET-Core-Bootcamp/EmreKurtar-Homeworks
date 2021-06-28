using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryDAL _categoryrepository = null;

        public CategoryService(ICategoryDAL categoryrepository)
        {
            _categoryrepository = categoryrepository;
        }

        public async Task<bool> Add(Category item)
        {
            int result = await _categoryrepository.Add(item);
            return result > 0;
        }

        public async Task<bool> Delete(Category item)
        {
            int result = await _categoryrepository.Delete(item);

            return result > 0;

        }

        public async Task<Category> Get(int itemid)
        {


            Category category = await _categoryrepository.Get(itemid);

            if(category != null)
            {
                return category;
            }
            else
            {
                return null;
            }
            
        }


        public async Task<List<Category>> GetAll()
        {
            return await _categoryrepository.GetAll();
        }

        public async Task<bool> Update(Category item)
        {
            int result = await _categoryrepository.Update(item);

            return result > 0;
        }
    }
}

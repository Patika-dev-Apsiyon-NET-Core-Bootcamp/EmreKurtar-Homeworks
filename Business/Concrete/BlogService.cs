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
    public class BlogService : IBlogService
    {
        private readonly IBlogDAL _blogrepository = null;

        public BlogService(IBlogDAL blogrepository)
        {
            _blogrepository = blogrepository;
        }


        public async Task<bool> Add(Blog blog)
        {
            int id = await _blogrepository.Add(blog);
            return id > 0;
        }

        public Task<bool> Delete(Blog blog)
        {
            throw new NotImplementedException();
        }

        public async Task<Blog> Get(int blogid)
        {
            return await _blogrepository.Get(blogid);
        }

        public Task<List<Blog>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<Blog>> GetAllByCategory(int categoryid)
        {
            return await _blogrepository.GetAllByCategory(categoryid);
        }

        public Task<bool> Update(Blog blog)
        {
            throw new NotImplementedException();
        }
    }
}

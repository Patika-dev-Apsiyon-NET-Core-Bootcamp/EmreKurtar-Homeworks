using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class BlogRepository : Repository<Blog>, IBlogDAL
    {

        public BlogRepository(MyDBContext context):base(context)
        {

        }

        public async Task<ICollection<Blog>> GetAllByCategory(int categoryid)
        {
            return await _context.Blogs.Where(x => x.Categories.Any(c => c.ID == categoryid)).ToListAsync();
        }
    }
}

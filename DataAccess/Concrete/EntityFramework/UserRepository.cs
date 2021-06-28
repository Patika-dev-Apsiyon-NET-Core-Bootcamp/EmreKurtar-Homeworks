using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class UserRepository : Repository<User>,IUserDAL
    {

        public UserRepository(MyDBContext context) : base(context)
        {

        }
    }
}

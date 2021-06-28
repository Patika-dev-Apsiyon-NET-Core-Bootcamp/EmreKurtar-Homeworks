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
    public class UserService : IUserService
    {
        private readonly IUserDAL _userrepository = null;

        public UserService(IUserDAL userrepository)
        {
            _userrepository = userrepository;
        }

        public Task<bool> Add(User item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(User item)
        {
            throw new NotImplementedException();
        }

        public Task<User> Get(int itemid)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(User item)
        {
            throw new NotImplementedException();
        }
    }
}

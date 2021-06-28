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
    public class CommentService : ICommentService
    {
        private readonly ICommentDAL _commentrepository = null;

        public CommentService(ICommentDAL commentrepository)
        {
            _commentrepository = commentrepository;
        }

        public Task<bool> Add(Comment item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Comment item)
        {
            throw new NotImplementedException();
        }

        public Task<Comment> Get(int itemid)
        {
            throw new NotImplementedException();
        }

        public Task<List<Comment>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Comment item)
        {
            throw new NotImplementedException();
        }
    }
}

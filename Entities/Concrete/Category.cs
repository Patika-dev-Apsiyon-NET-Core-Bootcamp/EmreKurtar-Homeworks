using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Category : Entity
    {
        public string CategoryName { get; set; }

        public virtual ICollection<Blog> Blogs { get; set; }

    }
}

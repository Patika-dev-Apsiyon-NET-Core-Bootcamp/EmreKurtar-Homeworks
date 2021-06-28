using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Comment : Entity
    {
        public string Text { get; set; }
        public virtual User User { get; set; }
        public virtual Blog Blog { get; set; }


    }

}
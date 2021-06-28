using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Blog : Entity
    {
        public string Header { get; set; }
        public string Text { get; set; }
        public bool IsDraft { get; set; }

        
        public virtual User User { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }


    }
}

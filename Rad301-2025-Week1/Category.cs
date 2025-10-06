using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rad301_2025_Week1
{
    public class Category
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Product> Products { get; set; }

        public Category(int id, string description)
        {
            ID = id;
            Description = description;
 

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Model
{
   public class Images:Base
    {
        public string Image { get; set; }

        // Each Image is belonged to one Product
        public ICollection<Product> Product { get; set; }

        // Each Image is belonged to one Category
        public ICollection<Category> Category { get; set; }
    }
}

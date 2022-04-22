using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Model
{
  public  class Reviews :Base
    {
        [ForeignKey("User")]
        public int UserID { get; set; }
        public User User { get; set; }

        // Each Review is given for one specific Product
        [ForeignKey("Product")]
        public int ProductID { get; set; }
        public Product Product { get; set; }

        [Required]
        public decimal Rate { get; set; }
    }
}

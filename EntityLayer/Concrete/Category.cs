using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category //Ctg
    {
        [Key]
        public int CategoryID { get; set; }
        public string ? CtgName { get; set; }
        public string ? CtgDescription { get; set; }
        public string ? CtgImage { get; set; }
        public bool ? CtgStatus { get; set; }
        public List<Product> Products { get; set; }
    }
}

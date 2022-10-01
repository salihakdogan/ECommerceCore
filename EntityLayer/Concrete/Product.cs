using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Product //Prd
    {
        public int ProductID { get; set; }
        public string ? PrdName { get; set; }
        public string ? PrdDescription { get; set; }
        public string ? PrdImage1 { get; set; }
        public string ? PrdImage2 { get; set; }
        public string ? PrdImage3 { get; set; }
        public int ? PrdPrice { get; set; }
        public bool ? PrdStatus { get; set; }
    }
}

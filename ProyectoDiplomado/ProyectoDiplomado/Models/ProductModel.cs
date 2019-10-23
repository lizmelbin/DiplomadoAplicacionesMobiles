using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoDiplomado.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public string ShortDescription{ get; set; }
        public string LongDescription{ get; set; }
        public decimal Price{ get; set; }
        public string ImageUrl{ get; set; }
        public string EbayLink{ get; set; }
        public bool IsProductOfTheWeek{ get; set; }
        public bool InStock{ get; set; }
    }
}

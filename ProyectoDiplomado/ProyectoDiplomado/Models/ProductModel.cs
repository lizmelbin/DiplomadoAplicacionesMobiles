using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoDiplomado.Models
{
    class ProductModel
    {
        public int Id { get; set; }
        public string ShortDescription{ get; set; }
        public string LongDescription{ get; set; }
        public decimal Price{ get; set; }
        public string ImageUrl{ get; set; }
        public bool isProductOfTheWeek{ get; set; }
        public bool inStrock{ get; set; }
    }
}

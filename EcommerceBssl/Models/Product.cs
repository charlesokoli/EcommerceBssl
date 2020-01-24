using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceBssl.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Double Price { get; set; }
        public Double OldPrice { get; set; }
        public int SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; }//property of the class product
        public ICollection<ProductColour> ProductColour { get; set; }
        public ICollection<Image> Images { get; set; }
    }
}

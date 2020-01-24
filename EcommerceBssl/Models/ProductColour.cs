using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceBssl.Models
{
    public class ProductColour
    {
        public int Id { get; set; }
        public string ProductId { get; set; }
        public string ColourId { get; set; }
        public Product Product { get; set; }
        public Colour Colour { get; set; }
    }
}

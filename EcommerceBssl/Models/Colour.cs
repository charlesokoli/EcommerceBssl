using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceBssl.Models
{
    public class Colour
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string code { get; set; }
        public ICollection<ProductColour> ProductColour { get; set; }
    }
}

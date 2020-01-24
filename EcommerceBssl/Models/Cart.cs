using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceBssl.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public DateTime? DateAdded { get; set; } //= DateTime.Now;    to pass default value
        public Enumerations.CartState CartState { get; set; }

        public int ProductId { get; set; }
        public string CustomerId { get; set; }
        [ForeignKey("Colour")] //data Annotation
        public int SeletedColourId { get; set; }
        [ForeignKey("Address")]
        public int SeletedAddressId { get; set; }

        public Customer Customer { get; set; }
        public Product Product { get; set; }
        public Colour Colour { get; set; }
        public Address Address { get; set; }


    }
   

}

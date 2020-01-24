using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceBssl.Models
{
    public class SubCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BannerImage { get; set; }
        public List<Product> Product { get; set; }

        public int MainCategoryId { get; set; } //foreigh key property

        public Maincategory Maincategories { get; set; }//nav property

    }
}

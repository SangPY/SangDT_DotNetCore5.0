using System;
using System.Collections.Generic;

#nullable disable

namespace SangDT_DotNetCore5._0.Models.Entities
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}

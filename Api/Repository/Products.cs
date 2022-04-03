using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Finance_Api.Repository
{
    public partial class Products
    {
        public Products()
        {
            Orders = new HashSet<Orders>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDetails { get; set; }
        public decimal Cost { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}

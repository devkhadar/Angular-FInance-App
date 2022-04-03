using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Finance_Api.Repository
{
    public partial class Orders
    {
        public int OrderId { get; set; }
        public string Email { get; set; }
        public int? Quantity { get; set; }
        public int? Productid { get; set; }
        public decimal TotalCost { get; set; }
        public int? EmiTenure { get; set; }

        public virtual UserRegistration EmailNavigation { get; set; }
        public virtual Products Product { get; set; }
    }
}

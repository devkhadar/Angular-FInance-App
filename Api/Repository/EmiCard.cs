using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Finance_Api.Repository
{
    public partial class EmiCard
    {
        public long EmiCardNumber { get; set; }
        public string Email { get; set; }
        public string CardType { get; set; }
        public decimal TotalCredit { get; set; }
        public decimal? CreditUsed { get; set; }
        public string Status { get; set; }
        public DateTime ValidTill { get; set; }

        public virtual UserRegistration EmailNavigation { get; set; }
    }
}

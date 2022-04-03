using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Finance_Api.Repository
{
    public partial class UserRegistration
    {
        public UserRegistration()
        {
            EmiCard = new HashSet<EmiCard>();
            Orders = new HashSet<Orders>();
        }

        public string FullName { get; set; }
        public DateTime? Dob { get; set; }
        public decimal PhoneNumber { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string AccPassword { get; set; }
        public string ConfirmPassword { get; set; }
        public string HomeAddress { get; set; }
        public string CardType { get; set; }
        public string BankName { get; set; }
        public decimal AccountNumber { get; set; }
        public string IfscCode { get; set; }
        public bool Approved { get; set; }

        public virtual ICollection<EmiCard> EmiCard { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}

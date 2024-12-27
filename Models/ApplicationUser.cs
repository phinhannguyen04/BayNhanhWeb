using Microsoft.AspNetCore.Identity;

namespace BayNhanhWeb.Models;

    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
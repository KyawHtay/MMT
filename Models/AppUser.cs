using System.Collections.Generic;

namespace MMT.Models
{
    public class AppUser
    {
         public int Id { get; set; }
        public string FirstName { get; set; } 
        public string LastName { get; set; } 
        public string Email { get; set; }
        public ICollection<Order> order {get;set;}
    }
}
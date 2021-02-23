using System.Collections.Generic;
using MMT.Models;

namespace MMT.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; } 
         public string LastName { get; set; } 
        public string Email { get; set; }
        public ICollection<Order> order {get;set;}
        
    }
}
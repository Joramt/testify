using System;
using System.Collections.Generic;

namespace TPFinal.Models
{
    public class User
    {
        public int Id { get; set; } 
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public int Status { get; set; }
        public String Password { get; set; }

        public virtual List<User> Users { get; set; } 
    }
}
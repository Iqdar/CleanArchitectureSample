using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Domain
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public string Email { get; set; }

        //Linking one to many
        public int RentalId { get; set; }
        public Rental Rental { get; set; }
    }
}

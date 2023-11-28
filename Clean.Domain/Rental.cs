using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Domain
{
    public class Rental
    {
        public int Id { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime RentalExpiry { get; set; }
        public decimal TotalCost { get; set; }

        //One to many relationship
        public ICollection<Member> Members { get; set; }

        //Many to many relation
        public IList<MovieRental> MovieRentals { get; set; }
    }
}

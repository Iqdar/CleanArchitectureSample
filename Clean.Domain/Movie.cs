using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Domain
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int RentalCost { get; set; }
        public int RentalDuration { get; set; }

        //Many to many relation
        public IList<MovieRental> MovieRentals { get; set; }
    }
}

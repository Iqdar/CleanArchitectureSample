using Clean.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Application.Commands
{
    public class CreateMovieCommand : IRequest<Movie>
    {
        public Movie newMovie { get; set; }
    }
}

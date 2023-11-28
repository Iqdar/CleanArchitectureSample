using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediatR;
using Clean.Domain;
using System.Threading.Tasks;

namespace Clean.Application.Queries
{
    public class GetAllMoviesQuery : IRequest<List<Movie>>
    {
    }
}

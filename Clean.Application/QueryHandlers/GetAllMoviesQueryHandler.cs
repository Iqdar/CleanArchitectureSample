using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Clean.Domain;
using Clean.Application.Queries;
using Clean.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Clean.Application.QueryHandlers
{
    internal class GetAllMoviesQueryHandler : IRequestHandler<GetAllMoviesQuery, List<Movie>>
    {
        private readonly MovieDbContext _movieDbContext;

        public GetAllMoviesQueryHandler(MovieDbContext movieDbContext)
        {
            _movieDbContext = movieDbContext;
        }

        public async Task<List<Movie>> Handle(GetAllMoviesQuery request, CancellationToken cancellationToken)
        {
            return await _movieDbContext.Movies.ToListAsync();
        }
    }
}

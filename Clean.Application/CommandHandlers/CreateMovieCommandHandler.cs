using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clean.Application.Commands;
using Clean.Domain;
using Clean.Infrastructure;
using MediatR;

namespace Clean.Application.CommandHandlers
{
    internal class CreateMovieCommandHandler : IRequestHandler<CreateMovieCommand, Movie>
    {
        private readonly MovieDbContext _movieDbContext;

        public CreateMovieCommandHandler(MovieDbContext movieDbContext)
        {
            _movieDbContext = movieDbContext;
        }

        public async Task<Movie> Handle(CreateMovieCommand request, CancellationToken cancellationToken)
        {
            _movieDbContext.Movies.Add(request.newMovie);
            await _movieDbContext.SaveChangesAsync();
            return request.newMovie;
        }
    }
}

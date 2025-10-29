using DPatterns.src.MovieBookingSystem.Application.Movies.Queries;
using DPatterns.src.MovieBookingSystem.Domain.Models;
using DPatterns.src.MovieBookingSystem.Infrastructure.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DPatterns.src.MovieBookingSystem.Application.Movies.Handlers
{
    public class GetAllMovieHandler : IRequestHandler<GetAllMovieQuery,IEnumerable<Movie>>
    {
        public readonly MovieRepository _movieRepository;
        public GetAllMovieHandler(MovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }
        public Task<IEnumerable<Movie>> Handle(GetAllMovieQuery query,CancellationToken cancellationToken)
        {
            var movies = _movieRepository.GetAll();
            return Task.FromResult(movies);
        }

    }
}

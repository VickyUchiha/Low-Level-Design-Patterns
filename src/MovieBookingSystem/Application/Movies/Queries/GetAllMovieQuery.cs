using DPatterns.src.MovieBookingSystem.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DPatterns.src.MovieBookingSystem.Application.Movies.Queries
{
    public record GetAllMovieQuery() : IRequest<List<Movie>>;

}

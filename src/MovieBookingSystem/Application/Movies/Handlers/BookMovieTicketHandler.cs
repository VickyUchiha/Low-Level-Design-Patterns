using DPatterns.src.MovieBookingSystem.Application.Movies.Commands;
using DPatterns.src.MovieBookingSystem.Infrastructure.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPatterns.src.MovieBookingSystem.Application.Movies.Handlers
{
    public class BookMovieTicketHandler : IRequestHandler<BookMovieTicketCommand,string>
    {
        private readonly MovieRepository _movieRepository;
        public BookMovieTicketHandler(MovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public async Task<string> Handle(BookMovieTicketCommand request,CancellationToken cancellationToken)
        {
            var movie = _movieRepository.GetById(request.MovieId);
            if ((movie != null && movie.AvailableSeats>=request.seats))
            {
                movie.AvailableSeats -= request.seats;
                _movieRepository.Update(movie);
                return await Task.FromResult("Ticket Booked Successfully!");
            }
            else
            {
                return await Task.FromResult("Ticket Booking Failed!");
            }
        }
    }
}

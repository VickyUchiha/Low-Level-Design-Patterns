using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPatterns.src.MovieBookingSystem.Application.Movies.Commands
{
    public record BookMovieTicketCommand(int MovieId,int seats) : IRequest<string>;
}

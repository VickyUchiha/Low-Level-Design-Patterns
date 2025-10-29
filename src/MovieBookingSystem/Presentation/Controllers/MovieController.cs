using DPatterns.src.MovieBookingSystem.Domain.Models;
using DPatterns.src.MovieBookingSystem.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using DPatterns.src.MovieBookingSystem.Application.Movies.Queries;
using Microsoft.AspNetCore.Mvc;
using DPatterns.src.MovieBookingSystem.Application.Movies.Commands;


namespace DPatterns.src.MovieBookingSystem.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller")]
    public class MovieController : ControllerBase
    {
        private readonly IMediator _mediator;
        public MovieController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetMovies()
        {
            var result = await _mediator.Send(new GetAllMovieQuery());
            return Ok(result);
        }

        [HttpPost("book")]
        public async Task<IActionResult> BookMovieTicket(BookMovieTicketCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

    }
}

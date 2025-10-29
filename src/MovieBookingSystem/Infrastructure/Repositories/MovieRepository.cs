using DPatterns.src.MovieBookingSystem.Domain.Models;
using DPatterns.src.MovieBookingSystem.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPatterns.src.LLD.DPatterns;
using System.Runtime.InteropServices.Marshalling;

namespace DPatterns.src.MovieBookingSystem.Infrastructure.Repositories
{
    public class MovieRepository : Domain.Interfaces.IRepository<Movie>
    {
        private readonly List<Movie> _movies = new()
        {
            new Movie()
            {
                Id = 1,Title = "Avengers",AvailableSeats = 100
            },
            new Movie()
            {
                Id = 2,Title = "SpiderMan",AvailableSeats = 100
            },
            new Movie()
            {
                Id = 3,Title = "BatMan",AvailableSeats = 100
            }
        };
        public void Add(Movie entity) => _movies.Add(entity);

        public void Delete(Movie entity) => _movies.Remove(entity);

        public IEnumerable<Movie> GetAll() => _movies;

        public Movie GetById(int id) => _movies.FirstOrDefault(_ => _.Id == id);

        public void Update(Movie entity)
        {
            var movie = _movies.FirstOrDefault(_ => _.Id == entity.Id);
            if (movie != null)
            {
                movie.AvailableSeats = entity.AvailableSeats;
                movie.Title = entity.Title;
                Logger.Instance.Log("Movie Updated!");
            }
            else  Logger.Instance.Log("Invalid Movie!");

        }
    }
}

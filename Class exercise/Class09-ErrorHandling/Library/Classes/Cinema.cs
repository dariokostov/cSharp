using System;
using System.Collections.Generic;

namespace Library.Classes
{
    public class Cinema
    {
        private string v;

        //Name, Halls , ListOfMovies
        public string Name { get; set; }
        public List<int> Halls { get; set; }
        public List<Movie> ListOfMovies { get; set; }

        public Cinema(string name, List<int> halls, List<Movie> listOfMovies)
        {
            this.Name = name;
            this.Halls = halls;
            this.ListOfMovies = listOfMovies;
        }

        public Cinema(string name)
        {
            this.Name = name;
        }

        public void MoviePlaying(Movie movie)
        {
            Console.WriteLine($"Watching {movie.Title}");
        }
    }
}

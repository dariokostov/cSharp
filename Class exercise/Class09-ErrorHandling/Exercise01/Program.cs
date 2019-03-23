using System;
using System.Collections.Generic;
using System.Linq;
using Library.Classes;
using Library.Enums;

namespace Exercise01
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Make a class Movie. Movie must have: Title, Genre, Rating, TicketPrice and a constructor for setting them
            //Rating should be a number from 1 to 5. Throw exception if its more or less(you should also handle other exceptions)
            //Set the TicketPrice to be 5 * Rating when creating a new object
            //Genre should be an enum with Comedy, Horror, Action, Drama and SciFi
            //Make a class Cinema. Cinema must have: Name, Halls , ListOfMovies
            //Cinema should have method MoviePlaying  that will have a parameter ‘movie’ and then print out in the console “Watching Movie.Name”
            //We will provide 10 movies per cinema to put in the cinema movies list

            //Make a user interface that will choose a cinema.
            //After that the user should chose if he likes to see all movies or by genre
            //All movies - show all movies and give option to choose a movie (the movie Playing method should be called)
            //By genre the user should input his favorite genre and a list of movies from that genre from the cinema should be displayed and give an option to choose one
            //If the user enter a wrong input throw an exception,
            //Handle all exceptions with Try/Catch

            #region Movies
            Movie movie1 = new Movie("Scary Movie", Genre.Comedy, 4, 2.5);
            Movie movie2 = new Movie("American Pie", Genre.Comedy, 4, 2.5);
            Movie movie3 = new Movie("Saw", Genre.Horror, 4, 2.5);
            Movie movie4 = new Movie("The Shining", Genre.Horror, 4, 2.5);
            Movie movie5 = new Movie("Rambo", Genre.Action, 4, 2.5);
            Movie movie6 = new Movie("The Terminator", Genre.Action, 4, 2.5);
            Movie movie7 = new Movie("Forrest Gump", Genre.Drama, 4, 2.5);
            Movie movie8 = new Movie("12 Angru Men", Genre.Drama, 4, 2.5);
            Movie movie9 = new Movie("Passengers", Genre.SciFi, 4, 2.5);
            Movie movie10 = new Movie("Interstellar", Genre.SciFi, 4, 2.5);
            List<Movie> MovieSet1 = new List<Movie>() { movie1, movie2, movie3, movie4, movie5, movie6, movie7, movie8, movie9, movie10 };

            Movie movie11 = new Movie("Airplane", Genre.Comedy, 4, 2.5);
            Movie movie12 = new Movie("Johnny English", Genre.Comedy, 4, 2.5);
            Movie movie13 = new Movie("The Ring", Genre.Horror, 4, 2.5);
            Movie movie14 = new Movie("Sinister", Genre.Horror, 4, 2.5);
            Movie movie15 = new Movie("RoboCop", Genre.Action, 4, 2.5);
            Movie movie16 = new Movie("Judge Dredd", Genre.Action, 4, 2.5);
            Movie movie17 = new Movie("The Social Network", Genre.Drama, 4, 2.5);
            Movie movie18 = new Movie("The Shawshank Redemption", Genre.Drama, 4, 2.5);
            Movie movie19 = new Movie("Inception", Genre.SciFi, 4, 2.5);
            Movie movie20 = new Movie("Avatar", Genre.SciFi, 4, 2.5);
            List<Movie> MovieSet2 = new List<Movie>() { movie11, movie12, movie13, movie14, movie15, movie16, movie17, movie18, movie19, movie20 };
            #endregion

            #region Cinema
            Cinema cinema1 = new Cinema("Cineplex");
            cinema1.Halls = new List<int>() { 1, 2, 3, 4 };
            cinema1.ListOfMovies = MovieSet1;
            Cinema cinema2 = new Cinema("Milenium");
            cinema2.Halls = new List<int>() { 1, 2 };
            cinema2.ListOfMovies = MovieSet2;
            #endregion
            try
            {
                Console.WriteLine($"Choose cinema: \n1) {cinema1.Name} \n2) {cinema2.Name}");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    CinemaMethod(cinema1);
                }
                else if (input == "2")
                {
                    CinemaMethod(cinema2);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("You did not enter a correct format and you broke it!");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("There is no movie like that!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void CinemaMethod(Cinema cinema)
        {
            Console.WriteLine("Choose movies or genre?");
            string inputMoviesOrGenre = Console.ReadLine();

            if (inputMoviesOrGenre == "movies")
            { 
                foreach (var movies in cinema.ListOfMovies)
                {
                    Console.WriteLine(movies.Title);
                }
                string inputMovie = Console.ReadLine();
                cinema.MoviePlaying(cinema.ListOfMovies.Where(movie => movie.Title.Trim().ToLower() == inputMovie.Trim().ToLower()).FirstOrDefault());

            }
            else if (inputMoviesOrGenre == "genre")
            {
                Console.WriteLine($"Choose Genre: \n1){Genre.Comedy}, \n2){Genre.Horror}, \n3){Genre.Action}, \n4){Genre.Drama}, \n5){Genre.SciFi}");
                string inputGenre = Console.ReadLine();
                Genre CGenre = new Genre();
                switch (inputGenre)
                {
                    case "1":
                        CGenre = Genre.Comedy;
                        break;
                    case "2":
                        CGenre = Genre.Horror;
                        break;
                    case "3":

                        CGenre = Genre.Action;
                    break;
                    case "4":
                        CGenre = Genre.Drama;
                    break;
                    case "5":
                        CGenre = Genre.SciFi;
                    break;
                    default:
                        throw new Exception("The genre input was not correct! Sorry, you broke it!");
                }
                Console.WriteLine("Choose a movie to watch: ( Write the name )");
                List<Movie> personMovies = new List<Movie>();
                foreach (var movie in cinema.ListOfMovies.Where(movie => movie.Genre == CGenre).ToList())
                {
                    personMovies.Add(movie);
                    Console.WriteLine(movie.Title);
                }
                string inputMovie = Console.ReadLine();
                cinema.MoviePlaying(personMovies.Where(movie => movie.Title.ToLower() == inputMovie.ToLower()).FirstOrDefault());
            }
        }
    }
}

using System;
using Library.Enums;

namespace Library.Classes
{
    public class Movie
    {
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public double Rating { get; set; }
        public double TicketPrice { get; set; }

        public Movie(string title, Genre genre, double rating, double ticketPrice)
        {
            this.Title = title;
            this.Genre = genre;
            try
            {
                if (rating > 0 && rating < 6)
                {
                    Rating = rating;
                }
                else
                {
                    throw new Exception("Rating must be from 1 to 5");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            this.TicketPrice = rating * ticketPrice;

        }
    }
}

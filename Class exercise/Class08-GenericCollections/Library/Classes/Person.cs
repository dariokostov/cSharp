using System;
using System.Collections.Generic;
using Library.Enums;

namespace Library.Classes
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Genre FavoriteMusicType { get; set; }
        public List<Song> FavoriteSongs { get; set; }

        public Person(string firstName, string lastName, int age, Genre favoriteMusicType)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FavoriteMusicType = favoriteMusicType;
        }

        public void GetFavSongs()
        {
            if(FavoriteSongs.Count > 0)
            {
                Console.WriteLine($"{FirstName} favorite songs:");
                foreach (var song in FavoriteSongs)
                {
                    Console.WriteLine(song.Title);
                }
            }
            else
            {
                Console.WriteLine($"{FirstName} hates music");
            }
            Console.WriteLine("---------------------");
        }
    }
}

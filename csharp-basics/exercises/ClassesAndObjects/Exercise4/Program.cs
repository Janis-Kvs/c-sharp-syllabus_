using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie[] movies = new Movie[3];
            movies[0] = new Movie("Casino Royale", "Eon Productions", "PG13");
            movies[1] = new Movie("Casino Glass", "Buena Vista International", "PG13");
            movies[2] = new Movie("Spider-Man: Into the Spider-Verse", "Columbia Pictures", "PG");

            foreach (Movie movie in movies)
            {
                Console.WriteLine($"Movie title: {movie.GetTitle()}, movie studio: {movie.GetStudio()}, movie rating:{movie.GetRating()}");
            }
            
            Console.WriteLine("Movies with rating \"PG\"");
            Movie[] newMovies = Movie.GetPg(movies);
            foreach (Movie movie in newMovies)
            {
                Console.WriteLine($"Movie title: {movie.GetTitle()}, movie studio: {movie.GetStudio()}, movie rating:{movie.GetRating()}");
            }
        }
    }
}

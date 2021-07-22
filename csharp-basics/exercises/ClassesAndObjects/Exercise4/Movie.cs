using System;

namespace Exercise4
{
    class Movie
    {
        private string _title;
        private string _studio;
        private string _rating;
        public Movie(string title, string studio, string rating)
        {
            _title = title;
            _studio = studio;
            _rating = rating;
        }
        public Movie(string title, string studio)
        {
            _title = title;
            _studio = studio;
            _rating = "PG";
        }
        public string GetTitle()
        {
            return _title;
        }
        public string GetStudio()
        {
            return _studio;
        }
        public string GetRating()
        {
            return _rating;
        }
        public static Movie[] GetPg(Movie[] movies)
        {
            Movie[] filteredMovies = Array.FindAll(movies, movie => movie.GetRating() == "PG");
            return filteredMovies;
        }
    }
}

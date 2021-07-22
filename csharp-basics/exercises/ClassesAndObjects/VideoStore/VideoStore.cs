using System;
using System.Collections.Generic;

namespace VideoStore
{
    class VideoStore
    {
        private List<Video> _movies;
        public VideoStore()
        {
            _movies = new List<Video>();
        }
        public void AddVideo(string title)
        {
            _movies.Add(new Video(title));
        }
        public void Checkout(string title)
        {
            var movie = FindMovieByTitle(title);
            movie?.BeingCheckedOut();
        }
        public void ReturnVideo(string title)
        {
            var movie = FindMovieByTitle(title);
            movie?.BeingReturned();
        }
        public void TakeUsersRating(double rating, string title)
        {
            var movie = FindMovieByTitle(title);
            movie?.ReceivingRating(rating);
        }
        public void ListInventory()
        {
            foreach (var movie in _movies)
            {
                Console.WriteLine(movie.ToString());
            }
        }
        private Video FindMovieByTitle(string title)
        {
            foreach (var movie in _movies)
            {
                if (movie.Title != title) continue;
                    return movie;
            }
            return null;
        }
    }
}

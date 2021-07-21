﻿using System.Collections.Generic;
using System.Linq;

namespace VideoStore
{
    class Video
    {
        private string _title;
        private bool _available;
        private List<double> _ratings;
        public Video(string title)
        {
            _title = title;
            _available = true;
            _ratings = new List<double>();
        }

        public void BeingCheckedOut()
        {
            _available = false;
        }

        public void BeingReturned()
        {
            _available = true;
        }

        public void ReceivingRating(double rating)
        {
            _ratings.Add(rating);
        }

        public double AverageRating()
        {
            return _ratings.Average();
        }

        public bool Available()
        {
            return _available;
        }

        public string Title => _title;

        public override string ToString()
        {
            return $"Title: {Title} Average rating: {AverageRating()} Available: {Available()}";
        }
    }
}

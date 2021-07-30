using System;
using System.Collections.Generic;
using System.Text;

namespace AdApp
{
    class Poster : Advert
    {
        private int _width;
        private int _height;
        private int _copies;

        public Poster(int fee) : base(fee)
        {
        }

        public Poster(int fee, int width, int height, int copies) : base(fee)
        {
            _width = width;
            _height = height;
            _copies = copies;
        }

        public override int Cost()
        {
            var fee = base.Cost()*(_width * _height)*_copies;
            return fee;
        }

        public override string ToString()
        {
            return $"\nPoster Cost = {Cost()}";
        }
    }
}

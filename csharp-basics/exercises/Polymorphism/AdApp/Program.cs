using System;

namespace AdApp
{
    class Program
    {
        private static void Main(string[] args)
        {
            var c = new Campaign();
            c.AddAdvert(new Advert(10));
            c.AddAdvert(new Hoarding(50, 7, 200));
            c.AddAdvert(new NewspaperAd(2, 30, 20));
            c.AddAdvert(new TVAd(50, 100, 30, true));
            c.AddAdvert(new Poster(10, 2, 3, 3));
            Console.WriteLine(c);
        }
    }
}
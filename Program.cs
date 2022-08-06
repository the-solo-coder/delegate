using System;
using System.Collections.Generic;

namespace MovieDelegate
{
    internal class Program
    {
        delegate bool filterMovies(Movie movie);

        static void Main(string[] args)
        {
            List<Movie> allMovies = PopulateMovies();

            DisplayMovies("Good For Kids", allMovies, IsGoodForKids);
            DisplayMovies("Released in the Last Decade", allMovies, WasReleasedInLastDecade);
            DisplayMovies("Box Office above 1 Billion Dollars", allMovies, WasBoxOfficeOverOneBillion);
        }

        static void DisplayMovies(string title,
            List<Movie> movies,
            filterMovies filter)
        {
            Console.WriteLine("---------------");
            Console.WriteLine(title);
            Console.WriteLine("---------------");

            foreach (Movie movie in movies)
            {
                if (filter(movie))
                    Console.WriteLine($" - {movie.ToString()}");
            }
            Console.WriteLine();
        }

        static bool IsGoodForKids(Movie movie)
        {
            bool confirm = false;

            if (movie.Classification == "PG")
                confirm = true;

            return confirm;
        }

        static bool WasReleasedInLastDecade(Movie movie)
        {
            bool confirm = false;

            if (movie.Year >= DateTime.Now.Year - 10)
                confirm = true;

            return confirm;
        }

        static bool WasBoxOfficeOverOneBillion(Movie movie)
        {
            bool confirm = false;

            if (movie.BoxOffice >= 1_000)
                confirm = true;

            return confirm;
        }

        static List<Movie> PopulateMovies()
        {
            List<Movie> movies = new List<Movie>();

            movies.Add(new Movie()
            {
                Id = 343818,
                Name = "I, Robot",
                Description = "In 2035, a technophobic cop investigates a crime that may have been perpetrated by a robot, which leads to a larger threat to humanity.",
                Category = "Sci-Fi",
                Rating = 7.1,
                Year = 2004,
                BoxOffice = 353.1,
                Classification = "PG-13"
            });


            movies.Add(new Movie()
            {
                Id = 212720,
                Name = "A.I. Artificial Intelligence",
                Description = "A highly advanced robotic boy longs to become 'real' so that he can regain the love of his human mother.",
                Category = "Sci-Fi",
                Rating = 7.2,
                Year = 2001,
                BoxOffice = 235.9,
                Classification = "PG-13"
            });

            movies.Add(new Movie()
            {
                Id = 107048,
                Name = "Groundhog Day",
                Description = "A narcissistic, self-centered weatherman finds himself in a time loop on Groundhog Day, and the day keeps repeating until he gets it right.",
                Category = "Comedy",
                Rating = 8.1,
                Year = 1993,
                BoxOffice = 105.0,
                Classification = "PG"
            });

            movies.Add(new Movie()
            {
                Id = 98282,
                Name = "See No Evil, Hear No Evil",
                Description = "Dave is deaf, and Wally is blind. They witness a murder, but it was Dave who was looking at her, and Wally who was listening.",
                Category = "Comedy",
                Rating = 6.8,
                Year = 1989,
                BoxOffice = 46.9,
                Classification = "R"
            });

            movies.Add(new Movie()
            {
                Id = 0068646,
                Name = "The Godfather",
                Description = "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son.",
                Category = "Crime",
                Rating = 9.2,
                Year = 1972,
                BoxOffice = 136.9,
                Classification = "R"
            });

            movies.Add(new Movie()
            {
                Id = 113497,
                Name = "Jumanji",
                Description = "When two kids find and play a magical board game, they release a man trapped in it for decades - and a host of dangers that can only be stopped by finishing the game.",
                Category = "Adventure",
                Rating = 7.0,
                Year = 1995,
                BoxOffice = 262.8,
                Classification = "PG"
            });

            movies.Add(new Movie()
            {
                Id = 391198,
                Name = "The Grudge",
                Description = "An American nurse living and working in Tokyo is exposed to a mysterious supernatural curse, one that locks a person in a powerful rage before claiming their life and spreading to another.",
                Category = "Horror",
                Rating = 5.9,
                Year = 2004,
                BoxOffice = 187.2,
                Classification = "PG-13"
            });

            movies.Add(new Movie()
            {
                Id = 10872600,
                Name = "Spider-Man: No Way Home",
                Description = "With Spider-Man's identity now revealed, Peter asks Doctor Strange for help. When a spell goes wrong, dangerous foes from other worlds start to appear, forcing Peter to discover what it truly means to be Spider-Man.",
                Category = "Action",
                Rating = 8.3,
                Year = 2021,
                BoxOffice = 1901.0,
                Classification = "PG-13"
            });

            movies.Add(new Movie()
            {
                Id = 107290,
                Name = "Jurassic Park",
                Description = "A pragmatic paleontologist touring an almost complete theme park on an island in Central America is tasked with protecting a couple of kids after a power failure causes the park's cloned dinosaurs to run loose.",
                Category = "Adventure",
                Rating = 8.2,
                Year = 1993,
                BoxOffice = 1046.0,
                Classification = "PG-13"
            });

            movies.Add(new Movie()
            {
                Id = 125439,
                Name = "Notting Hill",
                Description = "The life of a simple bookshop owner changes when he meets the most famous film star in the world.",
                Category = "Romance",
                Rating = 7.2,
                Year = 1999,
                BoxOffice = 363.9,
                Classification = "PG-13"
            });

            return movies;
        }
    }
}

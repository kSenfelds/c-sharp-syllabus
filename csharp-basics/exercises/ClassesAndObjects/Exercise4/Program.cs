namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie zero = new Movie("Test title", "Test studio", "PG");
            Movie one = new Movie("Casino Royale", "Eon Productions", "PG13");
            Movie two = new Movie("Glass", "Buena Vista International", "PG13");
            Movie three = new Movie("Spider-Man: Into the Spider-Verse", "Columbia Pictures");

            Movie[] movies = { zero, one, two, three };
            Movie[] pgMovies = Movie.GetPG(movies);

            foreach (Movie movie in pgMovies)
            {
                Console.WriteLine(movie);
            }
        }
    }
}
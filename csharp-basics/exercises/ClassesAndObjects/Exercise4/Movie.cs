namespace Exercise4
{
    internal class Movie
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

        public static Movie[] GetPG(Movie[] movies)
        {
            Movie[] result = new Movie[movies.Length];
            for (int i = 0; i < movies.Length; i++)
            {
                if (movies[i]._rating == "PG")
                {
                    result[i] = movies[i];
                }
            }

            return result;
        }
    }
}

namespace MovieDelegate
{
    public class Movie
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Category { get; set; }

        public double Rating { get; set; }

        public int Year { get; set; }

        public double BoxOffice { get; set; }

        public string Classification { get; set; }

        public override string ToString()
        {
            return $"{Id}: {Name} - Rating: {Rating} - Category: {Category}";
        }

        public Movie(int id,
            string name,
            string description,
            string category,
            double rating)
        {
            Id = id;
            Name = name;
            Description = description;
            Category = category;
            Rating = rating;
        }

        public Movie()
        {

        }
    }
}

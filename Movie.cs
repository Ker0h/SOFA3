class Movie
{
    public string Title { get; set; }

    public Movie(string title)
    {
        this.Title = title;
    }

    public void addScreening(MovieScreening screening)
    {
        // Add screening to movie
    }

    public string toString()
    {
        Console.WriteLine("Movie: " + this.Title);
    }
}
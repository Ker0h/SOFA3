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

    public override string ToString()
    {
        string movie = "Movie: " + this.Title;

        return movie;
    }
}
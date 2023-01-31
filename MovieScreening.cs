class MovieScreening
{
    public Movie Movie { get; set; }
    public DateTime DateAndTime { get; set; }
    public double PricePerSeat { get; set; }

    MovieScreening(Movie movie, DateTime dateAndTime, double pricePerSeat)
    {
        this.Movie = movie;
        this.DateAndTime = dateAndTime;
        this.PricePerSeat = pricePerSeat;
    }

    public string ToString()
    {
        Console.WriteLine("Movie: " + this.Movie.Title);
        Console.WriteLine("Date and time: " + this.DateAndTime);
        Console.WriteLine("Price per seat: " + this.PricePerSeat);
    }
}
class MovieScreening
{
    public Movie Movie { get; set; }
    public DateTime DateAndTime { get; set; }
    public double PricePerSeat { get; set; }

    public MovieScreening(Movie movie, DateTime dateAndTime, double pricePerSeat)
    {
        this.Movie = movie;
        this.DateAndTime = dateAndTime;
        this.PricePerSeat = pricePerSeat;
    }

    public double GetPricePerSeat(){
        return 10.0;
    }

    public override string ToString()
    {
        string movieScreening = "Movie: " + this.Movie.Title + Environment.NewLine;
        movieScreening += "Date and time: " + this.DateAndTime + Environment.NewLine;
        movieScreening += "Price per seat: " + this.PricePerSeat + Environment.NewLine;

        return movieScreening;
    }
}
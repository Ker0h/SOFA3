class MovieTicket
{
    public MovieScreening MovieScreening { get; set; }
    public int SeatNr { get; set; }
    public int RowNr { get; set; }
    public bool IsPremiumReservation { get; set; }

    public MovieTicket(MovieScreening movieScreening, int seatNr, int rowNr, bool isPremiumReservation)
    {
        this.MovieScreening = movieScreening;
        this.SeatNr = seatNr;
        this.RowNr = rowNr;
        this.IsPremiumReservation = isPremiumReservation;
    }

    public double getPrice()
    {
        // Calculate price of ticket
    }

    public String toString()
    {
        Console.WriteLine("Movie: " + this.MovieScreening.Movie.Title);
        Console.WriteLine("Date and time: " + this.MovieScreening.DateAndTime);
        Console.WriteLine("Price per seat: " + this.MovieScreening.PricePerSeat);
        Console.WriteLine("Seat: " + this.RowNr + this.SeatNr);
        Console.WriteLine("Premium seat: " + this.IsPremiumReservation);
    }
}
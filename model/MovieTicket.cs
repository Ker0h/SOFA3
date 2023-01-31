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
        return 10.0;
    }

    public override string ToString()
    {
        string movieTicket = "Movie: " + this.MovieScreening.Movie.Title + Environment.NewLine;
        movieTicket += "Date and time: " + this.MovieScreening.DateAndTime + Environment.NewLine;
        movieTicket += "Price per seat: " + this.MovieScreening.PricePerSeat + Environment.NewLine;
        movieTicket += "Seat number: " + this.SeatNr + Environment.NewLine;
        movieTicket += "Row number: " + this.RowNr + Environment.NewLine;
        movieTicket += "Premium reservation: " + this.IsPremiumReservation + Environment.NewLine;

        return movieTicket;
    }
}
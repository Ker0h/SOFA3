using System;

class Program
{
    static public void Main(String[] args)
    {
        Movie movie = new Movie("The Matrix");
        MovieScreening screening = new MovieScreening(movie, DateTime.Now, 10.0);
        MovieTicket ticket = new MovieTicket(screening, 1, 1, true);
        Order order = new Order(1, true);
        order.addSeatReservation(ticket);

        string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        Console.WriteLine("Exporting order to " + path);

        order.export(TicketExportFormat.PLAINTEXT);
        order.export(TicketExportFormat.JSON);
    }
}
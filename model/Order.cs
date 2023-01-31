using System.Text.Json;

class Order
{
    public int OrderNr { get; }
    public bool IsStudentOrder { get; set; }
    public List<MovieTicket> Tickets { get; set; } = new List<MovieTicket>();

    public Order(int orderNr, bool isStudentOrder)
    {
        this.OrderNr = orderNr;
        this.IsStudentOrder = isStudentOrder;
    }

    public void addSeatReservation(MovieTicket ticket)
    {
        this.Tickets.Add(ticket);
    }

    public double calculatePrice()
    {
        double totalAmount = 0;
        int amountOfTickets = Tickets.Count();
        int divider = 0;
        bool isMaDiWoDo = false;

        foreach(MovieTicket Ticket in Tickets){
            if(Ticket.MovieScreening.DateAndTime.DayOfWeek == DayOfWeek.Monday || Ticket.MovieScreening.DateAndTime.DayOfWeek == DayOfWeek.Tuesday || Ticket.MovieScreening.DateAndTime.DayOfWeek == DayOfWeek.Wednesday || Ticket.MovieScreening.DateAndTime.DayOfWeek == DayOfWeek.Thursday){
                isMaDiWoDo = true;
            }
                totalAmount += Ticket.getPrice();
                if(Ticket.IsPremiumReservation){
                    if(IsStudentOrder){
                        totalAmount += 2;
                    }else{
                        totalAmount += 3;
                    }
                }
            }
        if(IsStudentOrder || isMaDiWoDo){
            if(amountOfTickets % 2 == 0){
                divider = amountOfTickets / 2;
            }else{
                divider = amountOfTickets -1 / 2;
            }
        }
        if(!IsStudentOrder && !isMaDiWoDo && amountOfTickets >= 6){
            totalAmount = totalAmount * 0.9;
        }
        return 10.0;
    }

    public void export(TicketExportFormat exportFormat)
    {
        string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        switch (exportFormat)
        {
            case TicketExportFormat.PLAINTEXT:
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "Order.txt")))
                {
                    outputFile.WriteLine(this.ToString());
                }
                break;
            case TicketExportFormat.JSON:
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "Order.json")))
                {
                    var options = new JsonSerializerOptions { WriteIndented = true };
                    outputFile.WriteLine(JsonSerializer.Serialize(this, options));
                }
                break;
            default:
                break;
        }
    }

    public override string ToString()
    {
        string order = "Order number: " + this.OrderNr + Environment.NewLine;
        order += "Student order: " + this.IsStudentOrder + Environment.NewLine;
        order += "Tickets: " + Environment.NewLine;

        foreach (MovieTicket ticket in this.Tickets)
        {
            order += ticket.ToString() + Environment.NewLine;
        }

        return order;
    }
}
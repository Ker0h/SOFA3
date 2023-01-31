using Newtonsoft.Json;

class Order
{
    public int OrderNr { get; }
    bool isStudentOrder { get; set; }
    List<MovieTicket> tickets = new List<MovieTicket>();

    public Order(int orderNr, bool isStudentOrder)
    {
        OrderNr = orderNr;
        this.isStudentOrder = isStudentOrder;
    }

    public void addSeatReservation(MovieTicket ticket)
    {
        this.tickets.Add(ticket);
    }

    public double calculatePrice()
    {
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
                    outputFile.WriteLine(JsonConvert.SerializeObject(this));
                }
                break;
            default:
                break;
        }
    }

    public override string ToString()
    {
        string order = "Order number: " + this.OrderNr + Environment.NewLine;
        order += "Student order: " + this.isStudentOrder + Environment.NewLine;
        order += "Tickets: " + Environment.NewLine;

        foreach (MovieTicket ticket in this.tickets)
        {
            order += ticket.ToString() + Environment.NewLine;
        }

        return order;
    }
}
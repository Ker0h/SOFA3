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
class Order
{
    public int OrderNr { get; }
    bool isStudentOrder;

    public Order(int orderNr, bool isStudentOrder)
    {
        this.orderNr = orderNr;
        this.isStudentOrder = isStudentOrder;
    }

    public void addSeatReservation(MovieTicket ticket)
    {
        // Add seat reservation to order
    }

    public double calculatePrice()
    {
        // Calculate price of order
    }

    public void export(TicketExportFormat exportFormat)
    {
        // Export order to file
    }
}
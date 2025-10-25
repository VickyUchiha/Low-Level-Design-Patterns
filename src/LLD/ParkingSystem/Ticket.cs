public class Ticket
{
  public string TicketId { get; set; } 
  public Vehicle Vehicle { get; set; }  
  public DateTime EntryTime { get; set; } 
  public DateTime? ExitTime { get; set; }
  public decimal? AmountPaid { get; set; }
  
  public Ticket(Vehicle vehicle)
  {
    TicketId = Guid.NewGuid().ToString().Substring(0, 8);
    Vehicle = vehicle;
    EntryTime = DateTime.Now;
  }
}
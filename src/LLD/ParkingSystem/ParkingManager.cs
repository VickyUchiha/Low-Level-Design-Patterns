using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

public class ParkingManager
{
  private readonly ParkingLot ParkingLot;
  private readonly Dictionary<string, Ticket> ActiveTickets = new();

  public ParkingManager(ParkingLot parkingLot)
  {
    ParkingLot = parkingLot;
  }

  public Ticket? ParkVehicle(Vehicle vehicle)
  {
    var (slot, floor) = ParkingLot.FindSlot(vehicle);
    if (slot != null)
    {
      var isParked = slot.Park(vehicle);
      if (isParked)
      {
        var Ticket = new Ticket(vehicle);
        ActiveTickets[Ticket.TicketId] = Ticket;
        Console.WriteLine($"Parked {vehicle.VehicleType} at floor {floor.FloorNumber}, slot {slot.SlotId}");
        return Ticket;
      }
      else { return null; }
    }
    else
    {
      Console.WriteLine("No Slots Available!");
      return null;
    }
  }

  public void unParkVehicle(string ticketId)
  {
    if (!ActiveTickets.TryGetValue(ticketId, out var ticket))
    {
      Console.WriteLine("Invalid ticket!");
      return;
    }
    ticket.ExitTime = DateTime.Now;
    var duration = (ticket.ExitTime.Value - ticket.EntryTime).TotalHours;
    var rate = GetRate(ticket.Vehicle.VehicleType);
    ticket.AmountPaid = (decimal)duration * rate;

    foreach (var floor in ParkingLot.ParkingFloors)
    {
      var slot = floor.Slots.FirstOrDefault(_ => _.ParkedVehicle == ticket.Vehicle);
      if (slot != null)
      {
        slot.unPark();
        break;
      }
    }
    ActiveTickets.Remove(ticketId);
    Console.WriteLine($"Unparked {ticket.Vehicle.VehicleType}. Amount Paid: ₹{ticket.AmountPaid}");
  }
    private decimal GetRate(VehicleType type) =>
    type switch
        {
          VehicleType.Car => 50,
          VehicleType.Bike => 20,
          VehicleType.Truck => 100,
          _ => 0
        };
}
  

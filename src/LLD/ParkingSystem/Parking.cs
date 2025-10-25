public class ParkingLot
{
  public List<ParkingFloor> ParkingFloors { get; set; } = new();

  public ParkingLot(int floors,int carSlots,int bikeSlots,int truckSlots)
  {
    for(int i = 0; i < floors; i++)
    {
          ParkingFloors.Add(new ParkingFloor(i++,carSlots,bikeSlots,truckSlots));

    }
  }

  public (ParkingSlot?,ParkingFloor?) FindSlot(Vehicle vehicle)
  {
    foreach (var floor in ParkingFloors)
    {
      var slot = floor.GetAvailableSlot(vehicle.VehicleType);
      if (slot != null)
      {
        return (slot, floor);
      }
    }
    return (null, null);
  }

}

public class ParkingFloor
{
  public int FloorNumber { get; set; }
  public List<ParkingSlot> Slots { get; set; } = new();

  public ParkingFloor(int floorNumber, int carSlots, int bikeSlots, int truckSlots)
  {
    FloorNumber = floorNumber;
    var slots = new List<ParkingSlot>();
    int id = 1;
    for (int i = 0; i < carSlots; i++)
    {
      slots.Add(new ParkingSlot() { SlotId = id++, SlotType = VehicleType.Car });
    }
    for (int i = 0; i < bikeSlots; i++)
    {
      slots.Add(new ParkingSlot() { SlotId = id++, SlotType = VehicleType.Bike });
    }
    for (int i = 0; i < truckSlots; i++)
    {
      slots.Add(new ParkingSlot() { SlotId = id++, SlotType = VehicleType.Truck });
    }
  }

  public ParkingSlot? GetAvailableSlot(VehicleType vehicleType)
  {
    return Slots.FirstOrDefault(_ => _.SlotType == vehicleType && _.IsAvailable);
  }
}

public class ParkingSlot
{
  public int SlotId { get; set; }
  public bool IsAvailable { get; set; } =true;
  public Vehicle ParkedVehicle { get; private set; }
  public VehicleType SlotType { get; set; }

  public bool Park(Vehicle vehicle)
  {
    if (IsAvailable != true || vehicle.VehicleType != SlotType) return false;
    ParkedVehicle = vehicle;
    IsAvailable = false;
    return true;
  }
  public void unPark()
  {
    ParkedVehicle = null;
    IsAvailable = true;
  }
}
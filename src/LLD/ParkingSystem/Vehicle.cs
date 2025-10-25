public abstract class Vehicle
{
  public string LicensePlate { get; set; }
  public string Color { get; set; }
  public abstract VehicleType VehicleType { get; }
}

public enum VehicleType
{
  Car,
  Bike,
  Truck
}

public class Car : Vehicle
{
    public override VehicleType VehicleType => VehicleType.Car;
}

public class Bike : Vehicle
{
    public override VehicleType VehicleType => VehicleType.Bike;
}

public class Truck : Vehicle
{
    public override VehicleType VehicleType => VehicleType.Truck;
}
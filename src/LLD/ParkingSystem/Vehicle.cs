public abstract class Vehicle
{
  public string LicensePlate { get; set; }
  public string Color { get; set; }
  public abstract VehicleType VehicleType { get; }
  public abstract IParkingChargeStrategy ParkingChargeStrategy { get; }
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
    public override IParkingChargeStrategy ParkingChargeStrategy => new CarParkingChargeStrategy();
}

public class Bike : Vehicle
{
    public override VehicleType VehicleType => VehicleType.Bike;
    public override IParkingChargeStrategy ParkingChargeStrategy => new BikeParkingChargeStrategy();
}

public class Truck : Vehicle
{
    public override VehicleType VehicleType => VehicleType.Truck;
    public override IParkingChargeStrategy ParkingChargeStrategy => new TruckParkingChargeStrategy();
}

public interface IParkingChargeStrategy
{
    decimal CalculateCharge(decimal duration);
}

public class CarParkingChargeStrategy : IParkingChargeStrategy
{
    public decimal CalculateCharge(decimal duration) => duration * 50;
}
public class BikeParkingChargeStrategy : IParkingChargeStrategy
{
    public decimal CalculateCharge(decimal duration) => duration * 30;
}
public class TruckParkingChargeStrategy : IParkingChargeStrategy
{
    public decimal CalculateCharge(decimal duration) => duration * 70;
}
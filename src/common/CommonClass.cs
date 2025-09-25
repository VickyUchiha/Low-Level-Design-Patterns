public class CommonClass : AbstractClass, IInterface
{
  public override void display() => Console.WriteLine("This is an abstract method implemented in common class!");
  public void show() => Console.WriteLine("This is an interface method implemented in common class!");
}
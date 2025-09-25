using System;

public class StaticClass
{
  public static void NotMain()
  {
    BankAccount kirito = new BankAccount("kirito", 1000);
    BankAccount Ken = new BankAccount("Ken", 2000);

    kirito.ShowBalance();
    Ken.ShowBalance();

    Ken.Withdraw(3000);
    Ken.Withdraw(1000);
    Ken.ShowBalance();

    kirito.Deposit(1000);
    kirito.ShowBalance();
  }
}

public class BankAccount
{
  public string owner { get; set; }
  public double balance { get; set; }
  public BankAccount(string _owner, double _balance)
  {
    owner = _owner;
    balance = _balance;
  }

  public void Deposit(double amount)
  {
    balance += amount;
  }

  public void Withdraw(double amount)
  {
    if (balance < amount)
    {
      Console.WriteLine($"Insufficient balance : Balanace - ${balance}");
      return;
    }
    else balance -= amount;
  }

  public void ShowBalance()
  {
    Console.WriteLine($"Hi {owner}, your account balance is ${balance}");
  }
}
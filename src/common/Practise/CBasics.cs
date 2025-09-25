using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

public class CBasics
{
  public static void NotMain(string[] args)
  {
    //Day 1
    

    //Data Types in C#
    string city = "Chennai";
    dynamic data = 10;
    object obj = 20.5;

    System.Console.WriteLine($"City: {city}, Data: {data}, Object: {obj}");
    System.Console.WriteLine($"City Type : {city.GetType()}, Data Type : {data.GetType()}, Object Type : {obj.GetType()}");

    data = "Vignesh";
    obj = 100;
    System.Console.WriteLine($"City: {city}, Data: {data}, Object: {obj}");
    System.Console.WriteLine($"City Type : {city.GetType()}, Data Type : {data.GetType()}, Object Type : {obj.GetType()}");

    //Control flows in C#

    //if-else
    var number = 10;
    if (number > 0) Console.WriteLine($"{number} is a positive number");
    else if (number < 0)  Console.WriteLine($"{number} is a negative number");
    else  Console.WriteLine($"{number} is zero");



    //switch-case

    var role = "Admin";
    switch (role)
    {
      case "Admin":
        Console.WriteLine("Welcome, Admin! You have full access.");
        break;
      case "User":
        Console.WriteLine("Welcome, User! You have limited access.");
        break;
      default:
        Console.WriteLine("Role not recognized. Access denied.");
        break;
    }


    //Loops in C#
    //for loop

    for (int i = 0; i < 5; i++)
    {
      Console.WriteLine($"For Loop Iteration: {i}");
    }

    string str = "Hello";
    char[] charArray = str.ToCharArray();

    foreach (var item in charArray)
    {
      System.Console.WriteLine($"Foreach Loop Character : {item}");
    }

    foreach (var item in str)
    {
      System.Console.WriteLine($"Foreach Loop Character : {item}");
    }

    foreach (var item in Assembly.GetExecutingAssembly().GetTypes())
    {
      System.Console.WriteLine($"Foreach Loop Character : {item}");
    }


    //while loop

    int count = 10;

    while (count > 0)
    {
      System.Console.WriteLine($"While lool count : {count}");
      count--;
    }



    // Practise Problems
    // Reverse a string

    string input = "Hello world !";

    char[] chars = input.ToCharArray();

    int len = chars.Length;


    for (int i = len-1; i >= 0; i--)
    {
      if(chars[i] == ' ')
        continue;
      Console.WriteLine(chars[i]);
    } 

    // Factoria of a number

    int x = 4;
    int result = 1;

    while (x > 0)
    {
      result *= x;
      x--;
    }
    Console.WriteLine($"The Factorial of a number is {result}");


  }
}
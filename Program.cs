using System;
using System.Collections.Generic;

namespace Dealership
{
  class Program
  {
    public static void Main()
    {
      Car lexus = new Car("2012 Lexus", 12000, 123999);
      Car ford = new Car("2009 Ford", 3500, 150000);
      Car bmw = new Car("2010 BMW", 10000, 50000);
      Car nissan = new Car("2018 Nissan", 30000, 30000);

      List<Car> cars = new List<Car>() {lexus, ford, bmw, nissan};

      Console.WriteLine("Enter max price:");
      int maxPrice = int.Parse(Console.ReadLine());

      List<Car> affordableCars = new List<Car>(){};

      foreach(Car car in cars)
      {
        if (car.WorthToBuy(maxPrice))
        {
          affordableCars.Add(car);
        }
      }

      if (affordableCars.Count == 0)
      {
        Console.WriteLine("Sorry we don't have cars for this price or less.");
        Console.WriteLine("Would you like to try another search? Y for yes, Enter for no");
        if (Console.ReadLine().ToUpper() == "Y")
        {
          Main();
        }
      }
      else
      {
        foreach(Car car in affordableCars)
        {
          Console.WriteLine("_____________________________");
          Console.WriteLine(car.GetModel());
          Console.WriteLine("$" + car.GetPrice());
          Console.WriteLine(car.GetMiles() + " miles");
        }
      }
    }
  }
}

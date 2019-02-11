using System;
using System.Collections.Generic;

namespace Dealership
{
  public void Main()
  {

    Car lexus = new Car("2012 Lexus", 12000, 123999);
    Car ford = new Car("2009 Ford", 3500, 150000);
    Car bmw = new Car("2010 BMW", 10000, 50000);
    Car nissan = new Car("2018 Nissan", 30000, 30000);

    List<Car> cars = new List<Car>() {lexus, ford, bmw, nissan};

    Conlose.WriteLine("Enter max price:");
    int maxPrice = int.Parse(Console.ReadLine());

    List<Car> affordableCars = new List<Car>(){};
    foreach(car in cars)
    {
      if (car.WorthToBuy)
      {
        affordableCars.Add(car);
      }
    }

    foreach(car in affordableCars)
    {
      Console.WriteLine("_____________________________");
      Console.WriteLine(car.GetModel());
      Conlose.WriteLine(car.GetPrice());
      Conlose.WriteLine(car.GetMiles());
    }
  }
}

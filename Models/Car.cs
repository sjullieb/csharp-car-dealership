using System;

namespace Dealership
{
  class Car
  {
    private string Model;
    private int Price;
    private int Miles;

    public Car(string model, int price, int miles)
    {
      Model = model;
      Price = price;
      Miles = miles;
    }

    public void SetPrice(int newPrice)
    {
      Price = newPrice;
    }

    public string GetModel()
    {
      return Model;
    }

    public int GetPrice()
    {
      return Price;
    }

    public int GetMiles()
    {
      return Miles;
    }

    public bool WorthToBuy(int maxPrice)
    {
      return (Price <= maxPrice);
    }

  }
}

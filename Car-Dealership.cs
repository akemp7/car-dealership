using System;
using System.Collections.Generic;

class Car
{
  public string Info;
  public string MakeModel;
  public int Price;
  public int Miles;
  public Car(string info, string makeModel, int price, int miles)
  {
    Info = info;
    MakeModel = makeModel;
    Price = price;
    Miles = miles;
  }

  public bool WorthBuying(int maxPrice, int maxMiles)
  {
    return ((Price < maxPrice) && (Miles < maxMiles));
  }
}

public class Program
{
    public static void Main()
    {
        Car volkswagen = new Car("The Thing is a swamp monseter that was transformed by toxic waste.", "1974 Volkswagen Thing", 1100, 368792);
        Car yugo = new Car("A car made in the former USSR.", "1980 Yugo Koral", 700, 56000);
        Car ford = new Car("This vehicle has wood paneling and room for the whole family.", "1988 Ford Country Squire", 1400, 239001);
        Car amc = new Car("This vehicle is an over-priced Pinto.", "1976 AMC Pacer", 400, 198000);
        Console.WriteLine(yugo);
        List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc };

        Console.WriteLine("Enter maximum price: ");
        string stringMaxPrice = Console.ReadLine();
        int maxPrice = int.Parse(stringMaxPrice);
        Console.WriteLine("Enter maximum miles: ");
        string stringMaxMiles = Console.ReadLine();
        int maxMiles = int.Parse(stringMaxMiles);
        bool searchMatches = true;
        List<Car> CarsMatchingSearch = new List<Car>(0);

        foreach (Car automobile in Cars)
        {
            if (automobile.WorthBuying(maxPrice, maxMiles))
            {
                CarsMatchingSearch.Add(automobile);
            }
        }
            if (searchMatches == false)
            {
                Console.WriteLine("We do not have any cars that meet your search perameters.");
            }

        foreach (Car automobile in CarsMatchingSearch)
        {
            Console.WriteLine(automobile.MakeModel);
        }

    }
}
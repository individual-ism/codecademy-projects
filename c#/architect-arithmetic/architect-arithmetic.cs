using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("What momunment would you like to work with?");
      string monument = Console.ReadLine().ToUpper();

      void CalculateTotalCost(string monument)
      {
      double Rect(double length, double width)
      {
        return length * width;
      }

      double Circle(double radius)
      {
        return Math.PI * Math.Pow(radius, 2);
      }

      double Triangle(double bottom, double height)
      {
        return 0.5 * bottom * height;
      }

      
      double teotihuacan = Rect(1500, 2500) + Circle(375) + Triangle(750, 500);
      double tajMahal = Rect(90.5, 90.5) - 4 * Triangle(24, 24);
      double greatMosqueOfMecca = Rect(180, 106) + Rect(200, 264) + Triangle(84, 264);

      double totalArea = 0;
      switch (monument)
      {
        case "TEOTIHUACAN":
          totalArea = teotihuacan;
          break;
        case "TAJ MAHAL":
          totalArea = tajMahal;
          break;
        case "GREAT MOSQUE OF MECCA":
          totalArea = greatMosqueOfMecca;
          break;
      }

      double pesosCost = totalArea * 180;

      Console.WriteLine($"With an area of {totalArea}, the estimated cost of construction is {Math.Round(pesosCost, 2)} pesos.");
      }
      CalculateTotalCost(monument);
    }
  }
}

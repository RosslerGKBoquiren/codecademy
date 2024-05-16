using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {
      double teotihuacanRect = RectangularArea(1500, 2500);
      double teotihuacanCirc = (CircleArea(187.5)) / 2;
      double teotihuacanTri = TriangleArea(750, 500);
      double teotihuacanArea = Math.Round(teotihuacanRect + teotihuacanCirc + teotihuacanTri);
      double materialCost = Math.Round(teotihuacanArea * 180);
      Console.WriteLine($"Teotihuacan's total floor area is: {teotihuacanArea} sqm and the total cost for the materials are: {materialCost} Mexican Pesos");
    }

    static double RectangularArea(double length, double width) // define a method
    {
      double areaRect = length * width;
      return areaRect;
    }

    static double CircleArea(double radius)
    {
      double areaCirc = Math.PI * Math.Pow(radius, 2);
      return areaCirc;
    }

    static double TriangleArea(double bottom, double height)
    {
      double areaTri = 0.5 * bottom * height;
      return areaTri;
    }
  }
}

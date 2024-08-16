using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Calculate the areas of different parts of Teotihuacan
      double teotihuacanRect = CalculateRectangularArea(1500, 2500);
      double teotihuacanCirc = CalculateCircleArea(187.5) / 2;
      double teotihuacanTri = CalculateTriangleArea(750, 500);

      // Calculate the total area and round to 2 decimal places
      double teotihuacanArea = Math.Round(teotihuacanRect + teotihuacanCirc + teotihuacanTri, 2);

      // Calculate the total material cost and round to 2 decimal places
      double materialCost = Math.Round(teotihuacanArea * 180, 2);

      // Display the results
      Console.WriteLine($"Teotihuacan's total floor area is: {teotihuacanArea} sqm and the total cost for the materials is: {materialCost} Mexican Pesos");
    }

    static double CalculateRectangularArea(double length, double width)
    {
      // Calculate and return the area of the rectangle
      return length * width;
    }

    static double CalculateCircleArea(double radius)
    {
      // Calculate and return the area of the circle
      return Math.PI * Math.Pow(radius, 2);
    }

    static double CalculateTriangleArea(double bottom, double height)
    {
      // Calculate and return the area of the triangle
      return 0.5 * bottom * height;
    }
  }
}


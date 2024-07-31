using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");
      Console.Write("\nEnter an amount to convert: ");
      double amountToConvert = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine($"\n{amountToConvert} is equal to...");

      int gold = 10;
      int silver = 5;

      double goldCoins = Math.Floor(amountToConvert / gold);
      double remainder = amountToConvert % gold;

      double silverCoins = Math.Floor(remainder / silver);
      remainder = remainder % silver;

      Console.WriteLine($"Gold coins: {goldCoins} \nSilver coins: {silverCoins} \nBronze coins: {remainder}");
    }
  }
}

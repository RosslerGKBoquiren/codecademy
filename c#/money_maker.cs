using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");
      // ask the user for the amount to convert
      Console.Write("Enter the amount to convert: ");
      // capture the amount in a variable
      string amtConvert = Console.ReadLine();
      // convert the captured value to a number
      double amtConverted = Convert.ToDouble(amtConvert);
      // let the user know what you are about to do
      Console.WriteLine($"{amtConverted} cents is equal to...");

      // define two variables that holds the values of gold and silver
      int goldCoin = 10;
      int silverCoin = 5;

      /* find the maximum number of gold coin 
      divide the amount by the value of a gold coin.
      round down to nearest integer
      then store the result in a double variable called goldCoins*/
      double goldCoins = Math.Floor(amtConverted / goldCoin);
      // use modulo to find the remaining amount and store it in a double variable
      double leftover = amtConverted % goldCoin;
      // find the maximum number of silver coins that fit into the remainder
      double silverCoins = Math.Floor(leftover / silverCoin);
      // use modulo to find the remaining amount and store it in the existing remainder value
      leftover = leftover % silverCoin;

      // print out all of the coins
      Console.WriteLine($"Gold coins: {goldCoins}");
      Console.WriteLine($"Silver coins: {silverCoins}");
      Console.WriteLine($"Bronze coins: {leftover}");

    }
  }
}
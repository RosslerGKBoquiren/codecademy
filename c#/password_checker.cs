using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      // updated
      int minLength = 8;
      string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string lowercase = "abcdefghijklmnopqrstuvwxyz";
      string digit = "0123456789";
      string specialChars = "!@#$%^&*()-_=+";

      Console.Write("Enter a password: ");
      string passwordInput = Console.ReadLine();

      int score = 0;

      if (passwordInput.Length >= minLength)
      {
        score++;
      }

      if (Tools.Contains(passwordInput, uppercase))
      {
        score++;
      }

      if (Tools.Contains(passwordInput, lowercase))
      {
        score++;
      }

      if (Tools.Contains(passwordInput, digit))
      {
        score++;
      }

      if (Tools.Contains(passwordInput, specialChars))
      {
        score++;
      }

      Console.WriteLine(score);


      switch (score) 
      {
        case 4:
        case 5:
          Console.WriteLine("extremely strong");
          break;
        case 3:
          Console.WriteLine("strong");
          break;
        case 2:
          Console.WriteLine("medium");
          break;
        case 1:
          Console.WriteLine("weak");
          break;
        default:
          Console.WriteLine("password doesn't meet any of the standards");
          break;
      }

    }
  }
}

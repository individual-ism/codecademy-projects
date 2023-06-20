using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {

      int gold = 10;
      int silver = 5;

      Console.WriteLine("Welcome to Money Maker!");
      
      Console.WriteLine("What amount in cents do you want converted?");
      string strAmount = Console.ReadLine();
      double amount = Convert.ToDouble(strAmount);

      double goldCoins = Math.Floor(amount / gold);
      double remainder = amount % gold;
      double silverCoins = Math.Floor(remainder / silver);
      remainder = Math.Floor(remainder % silver);
      
      Console.WriteLine($"{amount} cents is equal to...");
      Console.WriteLine($"Gold coins: {goldCoins}");
      Console.WriteLine($"Silver coins: {silverCoins}");
      Console.WriteLine($"Bronze coins: {remainder}");

    }
  }
}



using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      int quarter = 25;
      int dime = 10;
      int nickel = 5;

      Console.WriteLine("Welcome to Money Maker!");
      
      Console.WriteLine("What amount in cents do you want converted into coinage?");
      string strAmount = Console.ReadLine();
      double amount = Convert.ToDouble(strAmount);

      double quarters = Math.Floor(amount / quarter);
      double remainder = amount % quarter;
      double dimes = Math.Floor(remainder / dime);
      remainder = Math.Floor(remainder % dime);
      double nickels = Math.Floor(remainder / nickel);
      remainder = Math.Floor(remainder % nickel)
      
      Console.WriteLine($"{amount} cents is equal to...");
      Console.WriteLine($"Quarters: {quarters}");
      Console.WriteLine($"Dimes: {dimes}");
      Console.WriteLine($"Nickels: {nickels}");
      Console.WriteLine($"Pennies: {remainder}");

    }
  }
}

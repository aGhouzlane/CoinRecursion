using System;

namespace recursion
{
  class Program
  {
    static void Main(string[] args)
    {
      double[] testArray = GetCoins(4.99, 0);
      string[] coins = { " Quarters", " Dimes", " Nickel", " Penny" };

      for (int i = 0; i < testArray.Length; i++)
      {
        Console.Write(testArray[i]);
        Console.Write(coins[i]);
        Console.WriteLine("");
      }
    }

    static double[] resultArray = { 0, 0, 0, 0 };
    public static double[] GetCoins(double n, int i)
    {
      double[] coins = { .25, .10, .05, .01 };
      resultArray[i] = Math.Floor(n / coins[i]);
      //base case
      if (i >= 3)
      {
        return resultArray;
      }
      return GetCoins(n % coins[i], i + 1);
    }
  }
}

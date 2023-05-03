using System;
using System.Linq;
using System.Collections.Generic;

namespace PrimeSifting.Models
{
  public class Primer
  {
    public static int InputNum { get; set; }
    public static List<int> Numbers { get; set; } = new List<int> { };
    public static List<int> Primes { get; set; } = new List<int> { };
    public static void Arrayer(int num)
    {
      InputNum = num;
      for (int i = 2; i <= num; i++)
      {
        Numbers.Add(i);
      }
      PrimeIt();
    }

    public static void PrimeIt()
    {
      Primes.Add(Numbers[0]);
    }
    
    public static void FindPrimes()
    {
      while (Numbers.Count > 0)
      {
        RemoveUnprimes();
      }
    }
    public static void RemoveUnprimes()
    {
      int p = Primes.Last();
      List<int> multiples = new List<int> {};
      foreach (int num in Numbers)
      {
        int nonprime = num * p;
        if (nonprime <= InputNum)
        {
          multiples.Add(num * p);
        }
        else
        {
          break;
        }
      }
      for (int i = 0; i < multiples.Count; i++)
      {
        foreach (int num in Numbers)
        {
          if (num == multiples[i])
          {
            // Console.WriteLine($"Numbers: {num}");
            // Console.WriteLine($"Multiples: {multiples[i]}");
            Numbers.Remove(num);
            break;
          }
        }
      }
      // (int num in multiples)
      // foreach (int num in multiples)
      // {
      //   Console.WriteLine(num);
      // }
      PrimeIt();
      Numbers.Remove(p);
      multiples.Clear();
    }
  }
}
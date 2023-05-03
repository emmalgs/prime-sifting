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

    public static void RemoveUnprimes()
    {
      int p = Primes.Last();
      List<int> multiples = new List<int> { };
      foreach (int num in Numbers)
      {
        int nonprime = num * p;
        if (nonprime < InputNum)
        {
          multiples.Add(num * p);
        }
        else
        {
          break;
        }
      }
      foreach (int num in multiples)
      {
        foreach (int otherNum in Numbers)
        {
          if (num == otherNum)
          {
            Numbers.Remove(otherNum);
            break;
          }
        }
      }
      PrimeIt();
    }
  }
}
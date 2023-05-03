using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Collections.Generic;
using PrimeSifting.Models;

namespace PrimeSifting.Tests
{
  [TestClass]
  public class PrimerTests : IDisposable
  {
    public void Dispose()
    {
      Primer.Numbers.Clear();
      Primer.Primes.Clear();
    }
    [TestMethod]
    public void Arrayer_ReturnsArrayFromTwoToN_IntArray()
    {
      int input = 11;
      int expected = 2;
      Primer.Arrayer(input);
      Assert.AreEqual(expected, Primer.Numbers[0]);
    }

    [TestMethod]
    public void Primes_ReturnsPrimeNumbers_Int()
    {
      int expected = 2;
      int input = 11;
      Primer.Arrayer(input);
      Assert.AreEqual(expected, Primer.Primes[0]);
    }

    [TestMethod]
    public void RemoveUnprimes_RemoveOneRoundOfUnprimes_Int()
    {
      int expected = 5;
      int input = 11;
      Primer.Arrayer(input);
      Primer.RemoveUnprimes();
      foreach (int num in Primer.Numbers)
      {
        Console.WriteLine(num);
      }
      Assert.AreEqual(expected, Primer.Numbers[1]);
    }

    [TestMethod]
    public void FindPrimes_ReturnsPrimeNumbers_Int()
    {
      int expected = 113;
      int input = 120;
      Primer.Arrayer(input);
      Primer.FindPrimes();
      Assert.AreEqual(expected, Primer.Primes.Last());
    }
  }
}
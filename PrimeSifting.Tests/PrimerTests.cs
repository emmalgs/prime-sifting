using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using PrimeSifting.Models;

namespace PrimeSifting.Tests
{
  [TestClass]
  public class PrimerTests
  {
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
      Assert.AreEqual(expected, Primer.Primes[0]);
    }
  }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(0);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    } 

    [TestMethod]
    public void CalculateBreadCost_ReturnsCostOfBreadOrder_int()
    {
      Bread newBread = new Bread(3);
      newBread.CalculateBreadCost();
      Assert.AreEqual(10, newBread.Cost);
    }
  }
}
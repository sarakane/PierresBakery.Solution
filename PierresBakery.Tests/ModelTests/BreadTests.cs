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
      Bread newBread = new Bread();
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    } 

    [TestMethod]
    public void CalculateBreadCost_ReturnsCostOfBreadOrder_int()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(10, newBread.CalculateBreadCost(3));
    }
  }
}
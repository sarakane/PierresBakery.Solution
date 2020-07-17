using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void CalculatePastryCost_ReturnsCostOfPastryOrder_int()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(5, newPastry.CalculatePastryCost(3));
    }
  }
}
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
      Pastry newPastry = new Pastry(0);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void CalculatePastryCost_CalculatesCostOfPastryOrder_void()
    {
      Pastry newPastry = new Pastry(3);
      newPastry.CalculatePastryCost();
      Assert.AreEqual(5, newPastry.Cost);
    }
  }
}
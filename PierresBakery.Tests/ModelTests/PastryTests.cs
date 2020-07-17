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
    public void GetCost_ReturnsCost_int()
    {
      Pastry newPastry = new Pastry(0);
      Assert.AreEqual(0, newPastry.Cost);
    }

    [TestMethod]
    public void GetOrderAmount_ReturnsOrderAmount_int()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(1, newPastry.OrderAmount);
    }

    [TestMethod]
    public void CalculatePastryCost_CalculatesCostOfPastryOrderInput3_void()
    {
      Pastry newPastry = new Pastry(3);
      newPastry.CalculatePastryCost();
      Assert.AreEqual(5, newPastry.Cost);
    }

    [TestMethod]
    public void CalculatePastryCost_CalculatesCostOfPastryOrderInput2_void()
    {
      Pastry newPastry = new Pastry(2);
      newPastry.CalculatePastryCost();
      Assert.AreEqual(4, newPastry.Cost);
    }

    [TestMethod]
    public void CalculatePastryCost_CalculatesCostOfPastryOrderInput4_void()
    {
      Pastry newPastry = new Pastry(4);
      newPastry.CalculatePastryCost();
      Assert.AreEqual(7, newPastry.Cost);
    }

    [TestMethod]
    public void CalculatePastryCost_CalculatesCostOfPastryOrderInput0_void()
    {
      Pastry newPastry = new Pastry(0);
      newPastry.CalculatePastryCost();
      Assert.AreEqual(0, newPastry.Cost);
    }
  }
}
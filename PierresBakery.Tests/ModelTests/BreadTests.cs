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
    public void CalculateBreadCost_CalculatesCostOfBreadOrderInput3_void()
    {
      Bread newBread = new Bread(3);
      newBread.CalculateBreadCost();
      Assert.AreEqual(10, newBread.Cost);
    }

    [TestMethod]
    public void CalculateBreadCost_CalculatesCostOfBreadOrderInput4_void()
    {
      Bread newBread = new Bread(4);
      newBread.CalculateBreadCost();
      Assert.AreEqual(15, newBread.Cost);
    }

    [TestMethod]
    public void CalculateBreadCost_CalculatesCostOfBreadOrderInput2_void()
    {
      Bread newBread = new Bread(2);
      newBread.CalculateBreadCost();
      Assert.AreEqual(10, newBread.Cost);
    }
    
    [TestMethod]
    public void CalculateBreadCost_CalculatesCostOfBreadOrderInput10_void()
    {
      Bread newBread = new Bread(0);
      newBread.CalculateBreadCost();
      Assert.AreEqual(0, newBread.Cost);
    }
  }
}
namespace PierresBakery.Models
{
  public class Bread
  {
    // Cost needs to be written this way to be able to change the value in the CalculateBreadCost method, but not change the value outside of the class
    private int _cost = 0;
    public int Cost 
    {
      get
      {
        return _cost;
      }
    }
    public int OrderAmount { get; } 

    public Bread(int amount)
    {
      OrderAmount = amount;
    }
    public void CalculateBreadCost()
    {
      _cost += ((OrderAmount/3)* 10);
      _cost += ((OrderAmount % 3) * 5);
    }
  }
}
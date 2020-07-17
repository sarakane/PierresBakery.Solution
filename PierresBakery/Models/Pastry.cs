namespace PierresBakery.Models
{
  public class Pastry
  {
    // Cost needs to be written this way to be able to change the value in the CalculateBreadCost method, but not change the value outside of the class
    private int _cost;
    public int Cost 
    {
      get
      {
        return _cost;
      }
    }
    public int OrderAmount { get; } 

    public Pastry(int amount)
    {
      _cost = 0;
      OrderAmount = amount;
    }
    public void CalculatePastryCost()
    {
      _cost += ((OrderAmount/3) * 5);
      _cost +=((OrderAmount % 3) * 2);
    }
  }
}
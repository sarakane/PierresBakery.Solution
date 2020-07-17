namespace PierresBakery.Models
{
  public class Bread
  {
    public int Cost {get; set;}
    public int OrderAmount { get; } 

    public Bread(int amount)
    {
      Cost = 0;
      OrderAmount = amount;
    }
    public void CalculateBreadCost()
    {
      Cost += ((OrderAmount/3)* 10);
      Cost += ((OrderAmount % 3) * 5);
    }
  }
}
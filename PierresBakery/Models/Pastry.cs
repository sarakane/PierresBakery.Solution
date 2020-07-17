namespace PierresBakery.Models
{
  public class Pastry
  {
    public int Cost {get; set;}
    public int OrderAmount { get; } 

    public Pastry(int amount)
    {
      Cost = 0;
      OrderAmount = amount;
    }
    public void CalculatePastryCost()
    {
      Cost += ((OrderAmount/3) * 5);
      Cost +=((OrderAmount % 3) * 2);
    }
  }
}
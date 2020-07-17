namespace PierresBakery.Models
{
  public class Bread
  {
    public int CalculateBreadCost(int breadAmount)
    {
      int cost = 0;
      cost += ((breadAmount/3)* 10);
      cost += ((breadAmount % 3) * 5);
      return cost;
    }
  }
}
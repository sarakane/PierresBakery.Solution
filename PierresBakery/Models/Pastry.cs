namespace PierresBakery.Models
{
  public class Pastry
  {
    public int CalculatePastryCost(int pastryAmount)
    {
      int cost = 0;
      cost += ((pastryAmount/3) * 5);
      cost +=((pastryAmount % 3) * 2);

      return cost;
    }
  }
}
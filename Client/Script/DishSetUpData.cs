namespace FoodCards.Client.Script
{
    public class DishSetUpData
    {
        public int DailyKalories { get; set; } = 2000;
        Dictionary<string, int> Goals { get; set; } = new();
        Dictionary<string, int> Limits { get; set; } = new();
    }
}

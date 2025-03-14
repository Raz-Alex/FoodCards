namespace FoodCards.Shared.Dish
{
    public class Meal : FoodItem
    {
        public List<FoodItem> Ingredients { get; set; } = new();
    }
}
